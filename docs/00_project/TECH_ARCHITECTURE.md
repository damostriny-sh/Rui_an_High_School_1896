# TECH_ARCHITECTURE — v0

Status: **stack adopted 15 Nov 2026 (D020); nothing has been built yet.** S1-05 is accepted only when the empty project builds once on the owner's machine and the exact versions are recorded in §1.
Stack from the Lead's recommendation as relayed by the owner, amended the same day with an art-pipeline stack (D021, §10). Structure, contracts and review notes by Claude. Items marked **[Proposal]** are not yet decided.

---

## 1. Stack

| Area | Choice | Version to record at setup | Note |
|---|---|---|---|
| Engine | Unity 6 | **6.3 LTS**, exact patch: ____ | 6.3 LTS is supported to December 2027; 6.0 LTS support ended October 2026 (Unity release page). Use 6.3 LTS, not 6.0 |
| Licence | Unity Personal | — | Free under US$200k revenue and funding in the last 12 months (Unity support) |
| Rendering | URP, Shader Graph, custom HLSL | URP: ____ | Reality toon look and Gray Space graphite look are both URP materials. HLSL only where Shader Graph can't do it. Detail in §10 |
| Modelling | Blender | ____ | Environment and hand assets; §10 |
| Language | C# | — | |
| Camera | Cinemachine | ____ | Follow camera, plus authored views for entry and Study |
| Animation | Animator, Animation Rigging | ____ | Rigging for hand IK: reaching, gripping, pointing |
| Input | Input System | ____ | Actions only; no screen asks for a specific key |
| AI | HFSM; NavMesh deferred | — | See §2 |
| Encounters | Custom C# encounter system | — | The stack calls this "modular combat system"; see §2 |
| Data | ScriptableObject | — | Authored content only; runtime state is plain C# (§6) |
| Scenes | Additive scene loading | — | §4 |
| Audio | FMOD Studio + FMOD for Unity | ____ | Free Indie licence covers projects with a development budget under US$600k; register the project in your FMOD profile (fmod.com/licensing) |
| Version control | Git + Git LFS on GitHub | Git ____, LFS ____ | §8 |
| Testing | Unity Test Framework | ____ | Edit-mode tests for rules; play-mode tests for scene flow |
| AI development | Claude Fable 5.2 | — | Whoever implements must be able to open Unity and run builds and tests on the owner's machine. The chat session that wrote this document cannot |

Not yet chosen, and not needed for the slice: localisation package, UI framework (UI Toolkit or uGUI), save format.

## 2. Review against Route A [Proposal]

The stack fits. Three items are scoped differently from how they're named, because Route A has no reflex combat (D010, D011):

1. **"Combat system" is an encounter system.** It's not hitboxes, damage numbers or attack chains. It's a question's state machine (`Entry → Held → Joined / SetAgainst / Substituted → Released`, plus `Left` and `Collapsed`), operations that transform that state, and one result per encounter. The only physical hits are the sweep knocking the student down and a wrong answer's strike. Name the code `Encounter`, not `Combat`, so the design isn't pulled back toward attack-and-dodge.
2. **NavMesh is deferred.** The hands are scripted state machines on fixed paths. The student moves on a small, flat arena. No character in the slice walks on its own. Add the AI Navigation package when the first walking NPC is designed.
3. **HFSM is for the hands and the game flow**, not for enemy AI in the usual sense: a hand's states are grip, warn (point), sweep and release.

Two further cautions:
- **FMOD before any audio exists** adds setup cost. That's acceptable if it's installed in S1-05, so audio work never has to migrate later. Keep Unity audio out of the code entirely so there's one audio path.
- **Paths use plain characters only.** The project folder is `Rui_an_High_School_1896` and file names contain no apostrophes (D022), because some build and command-line tools are fragile with special characters. Keep new file and folder names to letters, digits, `_` and `-`.

## 3. Repository and folders [Proposal]

One repository: the existing project folder is the repository root, and the Unity project is a subfolder. This keeps docs and references at the top, as they are now, under the same version history as the game. The roadmap puts docs inside the Unity project; this layout keeps that purpose (one source of truth) without moving any files.

```
Rui_an_High_School_1896/          <- Git root
├── .gitignore  .gitattributes
├── README.md  CLAUDE.md
├── docs/                          <- all design and production documents
├── reference/  reference_contact.jpg
├── handoff_hud/
├── art_source/                    <- Blender source files (.blend), outside Unity
└── Game/                          <- Unity project root (created by Unity Hub)
    ├── Assets/
    │   └── _Project/
    │       ├── Code/
    │       │   ├── Core/          (services, scene flow, clock, rules layer)
    │       │   ├── Encounter/     (question state, operations, hands)
    │       │   ├── Reality/       (rooms, interactables, free slot)
    │       │   ├── UI/            (HUD view; reads state, sends action requests)
    │       │   └── Tests/         (EditMode/, PlayMode/)
    │       ├── Data/              (ScriptableObject assets)
    │       ├── Scenes/
    │       ├── Art/  Audio/  Settings/
    ├── Packages/
    └── ProjectSettings/
```

Each folder under `Code/` gets its own assembly definition. `Core` depends on nothing; `Encounter`, `Reality` and `UI` depend on `Core` only, never on each other. Tests reference what they test.

## 4. Scenes [Proposal]

| Scene | Loaded | Contains |
|---|---|---|
| `Boot` | First, then stays | Services, camera rig, HUD, FMOD listener, scene loader |
| `Reality_Taoshe` | Additive | The 陶舍 room (SCENE_TAOSHE_ROOM.md) |
| `Gray_SippingMountain` | Additive | The Gray Space room (FIRST_SLICE_DESIGN §7) |
| `Test_Encounter_TwoTrays` | Alone, for development | Primitives only: WP3 grey box |

The switch: `Reality_Taoshe` stays loaded but hidden while `Gray_SippingMountain` loads, so the return lands in the same room with props in place. The two rooms are separate scenes so that WP4–WP6 (Gray Space) and WP7 (reality) can be worked on by different people without conflicts (PRODUCTION_PIPELINE §5).

## 5. Contracts between systems [Proposal]

Names first, so that WP3, WP7 and WP8 agree before any code is written.

**Encounter result.** Emitted exactly once per encounter.
```
EncounterResult {
  string questionTypeId   // "two_trays"
  string instanceId       // "two_trays_01"
  Outcome outcome         // Released | Left | Collapsed
  Road road               // Join | SetAgainstCarry | Guess | None
  int wrongGuesses
  int sweepsTaken
  float secondsInside
}
```

**Rules layer** (`Core`). The only place that changes health, time and marks. Applies a result once; applying the same result twice changes nothing (PRODUCTION_PIPELINE §2, engineering row).

**Player state** (plain C#, observable): `health`, `sanity`, `schoolTime`, `worksheetState[questionIndex]`, `freeSlotChoice`, `tracesPending`.

**HUD.** Reads player state; sends action requests (`Interact`, `Study`, `Push`, `Answer(n)`, `Leave`). It never changes state itself (HUD_handoff; FIRST_SLICE_DESIGN §8).

**Input actions.** `Move`, `Interact`, `Study` (hold), `Push`, `Answer`, `Leave` (hold), `Pause`. Key bindings live only in the Input Actions asset.

## 6. Data [Proposal]

| ScriptableObject | Holds |
|---|---|
| `QuestionType` | Id, body parts, which placements produce which transformation, sweep interval range, warning time |
| `QuestionInstance` | Type reference, the two tray values, the answer |
| `CostTable` | Health per sweep hit, per wrong guess, for leaving; school minutes per minute inside |
| `WorksheetStates` | The four page textures per question, keyed by `Road` |

ScriptableObjects hold authored content and are never written at runtime. The second data instance must run with no code change (WP3 acceptance). Starting numbers come from the tabletop test (`docs/04_playtest/`), not from this document.

## 7. Testing

- **Edit mode:** rules layer (a result applied twice changes nothing); every operation's transformation for both instances; each road reaches the right `Road` value; leave costs more than understanding and less than blind guessing under the current `CostTable`.
- **Play mode:** switch and return restore the right room, time and worksheet state; one result per encounter, including when Leave is held during a sweep.
- **Rule:** crash and save bugs are fixed before new work (development standard carried over from earlier planning).

## 8. Version control

- `.gitignore` and `.gitattributes` are in the repository root, prepared for the `Game/` layout. Unity's generated folders (`Library`, `Temp`, `Logs`, `obj`, `Build`, `UserSettings`) are ignored.
- **LFS** tracks images, models, audio, video, fonts and FMOD banks. Unity text assets (`.unity`, `.prefab`, `.asset`, `.meta`) stay in normal Git.
- **GitHub LFS quota depends on the account.** GitHub's current billing page lists 10 GiB of storage and 10 GiB a month of bandwidth on GitHub Free, while older pages state 1 GB. Check the figure under your own account's billing settings before the first big push. The reference photos alone are about 65 MB.
- **Branches:** `main` must always open and build. Each work package gets its own branch and merges after its acceptance evidence is attached.
- **Commit messages** name the work package: `WP3: ...`.

## 9. Setup steps for S1-05 (owner, about an hour)

1. Install **Git** and **Git LFS**, then run `git lfs install` once.
2. Install **Unity Hub**, then **Unity 6.3 LTS** (latest patch) with *Windows Build Support*.
3. In Unity Hub, create a project from the **Universal 3D** template, named `Game`, located in `D:\Rui_an_High_School_1896\`.
4. Install **Blender** (current stable release).
5. Open the Unity project. In Package Manager, add **Cinemachine**, **Input System** (accept the restart), **Animation Rigging**, and **Test Framework** if it's not already present. Install **FMOD for Unity** from FMOD's site or the Asset Store.
6. Build the empty scene once for Windows. Record every version number in §1.
7. In the project folder: `git init`, `git add .`, `git commit -m "S1-05: empty Unity 6.3 project"`. Create a **private** GitHub repository and push.
8. Tell the Lead it's done, with the build result and the versions. S1-05 is then accepted.

## 10. Art pipeline stack (D021)

Added by the owner on 15 Nov. It extends §1 and replaces none of it: input, animation, audio, Git and testing stay as listed there.

| Layer | Item | Purpose in this project | Review [Proposal] |
|---|---|---|---|
| Shader Graph | Graphite Material | Paper grain, graphite tone and directional smudge on Gray Space surfaces | Core. Must pass the baseline test: form, limbs and scale read with it **off** (ART_DIRECTION, Acceptance) |
| Shader Graph | Hatching | Tone built from directional strokes, following form | Core |
| Shader Graph | Outline | Uneven edge lines | Core. Keep edges imperfect; a clean uniform outline reads as cel-shading, not pencil |
| Custom HLSL | Screen Space Pencil | Unifies the frame as one drawing on paper | **Risk.** The baseline says the Gray Space is *not* "a normal scene with a pencil filter". Allowed as a final unifying layer over object materials, never as the main source of the look. Look-test captures are taken with it on and off |
| Custom HLSL | Distortion | — | **Limit to the switch.** Usable for the transition between worlds. Not as a sanity effect: the creative proposal rejects screen distortion for low sanity, and reality must stay plausible (CREATIVE_PROPOSAL §2.3, item 6) |
| Custom HLSL | Glitch | — | **Conflicts with the visual language.** Glitch is a digital artefact. The Gray Space is made of paper, graphite and bodies. Proposed instead: a paper-native equivalent (smear, erasure, a torn edge) for the same moments. The owner decides |
| Cinemachine | Third Person | Follow camera behind the student | As §1 |
| Cinemachine | Art Composition Zones | Authored views that hold a drawing's composition: Gray Space entry, Study, reality seated view | Matches the anchors (Focal, Foreground, Limb, Player, Background) in FIRST_SLICE_DESIGN §7.4 |
| Blender | Low-poly Environment | Room shells and props | "Low-poly" here means a modest polygon budget, not a faceted style. Reality stays semi-realistic (ART_DIRECTION) |
| Blender | Giant Hand Assets | Hands and forearm sections, rigged for gestures | Built after the untextured blockout is approved (PRODUCTION_PIPELINE §3). Every asset goes in the provenance log |
| ScriptableObject | Scene Blueprint | A scene recipe as data: anchors, scale hierarchy, limb stacks, camera zones, navigable area | The data form of the scene recipes already written (FIRST_SLICE_DESIGN §7, SCENE_TAOSHE_ROOM). Starts as data for one room; tooling waits for a second room (PRODUCTION_PIPELINE §4) |
| ScriptableObject | Art Style Profile | One profile per world: material, hatching, outline and post-effect parameters, saturation rules | Reality and Gray Space each get one. The switch interpolates between them |
| Claude Fable 5.2 | Art Analysis | Reading the owner's drawings and photos into observed facts | Observation kept separate from invention, as in the existing recipes |
| Claude Fable 5.2 | Scene Blueprint | Drafting recipes and blueprint data | The owner approves each recipe |
| Claude Fable 5.2 | Shader Coding | Shader Graph and HLSL | Needs access to Unity on the owner's machine to verify results |
| Claude Fable 5.2 | Tool Development | Editor tools | Only for steps repeated after the manual pass (PRODUCTION_PIPELINE §4) |
| Claude Fable 5.2 | Screenshot Review | Comparing engine captures with the source drawing, using the six-point list | Reports differences. Aesthetic acceptance stays with the owner |

**Blender** is free and open source. Record its version with the others. Exported `.fbx` and source `.blend` files go through Git LFS (§8).

**Folders added:** `Assets/_Project/Art/Shaders/` (Graph and HLSL), `Assets/_Project/Data/Blueprints/`, `Assets/_Project/Data/StyleProfiles/`. Blender source files live outside the Unity project in `art_source/` at the repository root, so Unity doesn't import them.

## 11. Not built in this phase

Save system, localisation, timetable, rank, NavMesh, procedural generation, CI builds. Each is added when a work package needs it, and is recorded here then.
