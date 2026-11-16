# TECH_ARCHITECTURE — v0

Status: **stack adopted 15 Nov 2026 (D020). Empty project built once on the owner's machine on 15 Nov 2026; versions recorded in §1, setup record in §9.1.** The owner chose Unity 6.6 instead of 6.3 LTS (D023). S1-05 accepted 15 Nov 2026 on the build evidence in §9.1; FMOD for Unity is still to be installed (S1-09).
Stack from the Lead's recommendation as relayed by the owner, amended the same day with an art-pipeline stack (D021, §10). Structure, contracts and review notes by Claude. Items marked **[Proposal]** are not yet decided.

---

## 1. Stack

| Area | Choice | Version recorded at setup (15 Nov 2026) | Note |
|---|---|---|---|
| Engine | Unity 6 | **6000.6.9f1 (Unity 6.6)**, revision 8c45277fb9c5. Unity Hub 4.0.0 | Amends D020 (D023). 6.6 is a Supported release: it gets fixes until the next release, 6.7, which Unity has scheduled as the next LTS for Q4 2026. Plan: stay on 6.6 and move to 6.7 LTS once it ships and before content production starts, testing the upgrade on a branch |
| Licence | Unity Personal | — | Free under US$200k revenue and funding in the last 12 months (Unity support) |
| Rendering | URP, Shader Graph, custom HLSL | URP 17.6.0, Shader Graph 17.6.0 | Reality toon look and Gray Space graphite look are both URP materials. HLSL only where Shader Graph can't do it. Detail in §10 |
| Modelling | Blender | 5.3.0 | Environment and hand assets; §10 |
| Language | C# | — | |
| Camera | Cinemachine | 6.6.0 | Follow camera, plus authored views for entry and Study |
| Animation | Animator, Animation Rigging | Animation Rigging 6.6.0 | Rigging for hand IK: reaching, gripping, pointing |
| Input | Input System | 1.20.1 | Actions only; no screen asks for a specific key |
| AI | HFSM; NavMesh deferred | — | See §2 |
| Encounters | Custom C# encounter system | — | The stack calls this "modular combat system"; see §2 |
| Data | ScriptableObject | — | Authored content only; runtime state is plain C# (§6) |
| Scenes | Additive scene loading | — | §4 |
| Audio | FMOD Studio + FMOD for Unity | **Not installed yet** (needs the owner's FMOD account) | Free Indie licence covers projects with a development budget under US$600k; register the project in your FMOD profile (fmod.com/licensing) |
| Version control | Git + Git LFS on GitHub | Git 2.55.0.windows.3, LFS 3.7.1, GitHub CLI 2.104.0 | §8. Repository: https://github.com/damostriny-sh/Rui_an_High_School_1896 (public) |
| Testing | Unity Test Framework | 1.8.0 | Edit-mode tests for rules; play-mode tests for scene flow |
| AI development | Claude Fable 5.2 | — | Whoever implements must be able to open Unity and run builds and tests on the owner's machine. The chat session that wrote this document cannot |

Not yet chosen, and not needed for the slice: localisation package, UI framework (UI Toolkit or uGUI), save format.

## 2. Review against Route A [Proposal]

The stack fits. Three items are scoped differently from how they're named, because Route A has no reflex combat (D010, D011):

1. **"Combat system" is an encounter system.** It's not hitboxes, damage numbers or attack chains. It's a question's state machine (`Entry → Held → Joined / SetAgainst / Substituted → Released`, plus `Left` and `Collapsed`), operations that transform that state, and one result per encounter. The only physical hits are the sweep knocking the student down and a wrong answer's strike. Name the code `Encounter`, not `Combat`, so the design isn't pulled back toward attack-and-dodge.
2. **NavMesh is deferred.** The hands are scripted state machines on fixed paths. The student moves on a small, flat arena. No character in the slice walks on its own. Add the AI Navigation package when the first walking NPC is designed.
3. **HFSM is for the hands and the game flow**, not for enemy AI in the usual sense: a hand's states are grip, warn (point), sweep and release.

Two further cautions:
- **FMOD before any audio exists** adds setup cost. The Sprint tracks installation separately as S1-09 before the first audio integration package. Keep Unity audio out of the code entirely so there's one audio path.
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

Before WP3, resolve live health events versus return settlement, the identity of each encounter run, mixed paths, collapse priority and repeated callbacks. Use approved WP1 rules to set behavior and acceptance checks.

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
- **The repository is public** (D024). Everything committed, including the owner's drawings, the campus photos and all documents, can be seen and downloaded by anyone. There is no licence file, so by default nobody else has the right to reuse it, but that doesn't stop copying. LFS downloads by anyone count against the owner's bandwidth quota.

## 9. Historical setup draft for S1-05

These steps preserve the pre-D023 setup draft. For the actual editor, packages and build, use §1 and §9.1.

1. Install **Git** and **Git LFS**, then run `git lfs install` once.
2. Install **Unity Hub**, then **Unity 6.3 LTS** (latest patch) with *Windows Build Support*.
3. In Unity Hub, create a project from the **Universal 3D** template, named `Game`, located in `D:\Rui_an_High_School_1896\`.
4. Install **Blender** (current stable release).
5. Open the Unity project. In Package Manager, add **Cinemachine**, **Input System** (accept the restart), **Animation Rigging**, and **Test Framework** if it's not already present. Install **FMOD for Unity** from FMOD's site or the Asset Store.
6. Build the empty scene once for Windows. Record every version number in §1.
7. In the project folder: `git init`, `git add .`, `git commit -m "S1-05: empty Unity 6.3 project"`. Create a GitHub repository and push. (The owner chose a public repository; see §8 and D024.)
8. Tell the Lead it's done, with the build result and the versions. S1-05 is then accepted.

### 9.1 Setup record, 15 Nov 2026

Carried out by Claude on the owner's machine, with the owner installing Unity Hub and the editor and logging in to GitHub.

| Step | Result |
|---|---|
| 1. Git, LFS | Already installed; `git lfs install` run |
| 2. Unity | Unity Hub 4.0.0; editor 6000.6.9f1 in `D:\Unity\Hub\Editor\`, with Windows build support. **Not 6.3 LTS** (see §1) |
| 3. Project | Created in `Game\` from the Universal 3D template (`com.unity.template.urp-blank-17.2.6`) in batch mode |
| 4. Blender | 5.3.0 in `C:\Program Files\Blender Foundation\Blender 5.3\` (replaced the owner's 5.1.0 in `D:\Blender\`) |
| 5. Packages | Cinemachine, Animation Rigging and Test Framework added; Input System came with the template. **FMOD for Unity not installed** |
| 6. Build | Windows 64-bit, scene `Assets/Scenes/SampleScene.unity`: `Build Finished, Result: Success`, 0 errors, 0 warnings, 58 s, 104.6 MB, output `Game\Build\Windows\Game.exe` (git-ignored). The built player was not launched |
| 7. Git | First commit `af86f95` on `main`: 113 files, 23 in LFS (53 MB). Pushed to GitHub; the repository was created private and made public at the owner's request |

Notes for the Lead:
- `Game/Assets/_Project/Editor/S105Setup.cs` adds the packages and runs the Windows build from the command line. It is not in the §3 folder plan; keep or delete.
- Unity's log warned that it could not verify the Hub 4.0 licensing client's signature and that an access token was unavailable. Licensing still resolved and every run finished; watch for it on later builds.
- §9 step 7 says the repository is private; it is now public, so the reference photos in `reference/` and the documents are publicly visible.

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

## 12. Build evidence

The local Unity summary is at Game/Library/BuildHistory/20261115-131714Z-005ad2f4/BuildReportSummary.json. It records a successful empty Windows player build in 58.026 seconds, with zero errors and zero warnings. Build history is local evidence under the ignored Unity cache; §9.1 records the evidence in the repository. See CURRENT_SPRINT.md for acceptance and FMOD status.
