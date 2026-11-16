# PRODUCTION_PIPELINE

> 适用范围：D016 采用本文件 WP 顺序替代旧原型任务。旧工具假设、初始状态及目录设想保留为编写时记录。实装版本见技术文档，实时任务状态见冲刺表。

Status: **proposal; Route A selected by the owner on 15 Nov. No work package below has started, apart from the owner's answers under WP0.** Sized for one encounter and one environment (`FIRST_SLICE_DESIGN.md`). Author: Claude. Date: 15 Nov 2026.

---

## 1. Assumptions about tools, stated honestly

| Statement | Basis |
|---|---|
| The project folder holds references and documents only. There is no game project | Seen in the folder listing |
| The engine is not chosen. Unity with URP is a candidate | `GAME_MASTER.md` |
| I can read and write files in the project folder and produce documents, images, vector drawings, browser-based mock-ups and source code | Done in this session |
| I have **not** verified that I can run a game engine, build, or playtest on the owner's computer | Not attempted |
| The two assistants do not communicate directly; the owner carries files between them | `GAME_MASTER.md` |
| Who models, rigs and animates is undecided | Not stated anywhere |

Any step below that needs an engine names an **implementer** role and does not presume who that is.

Roles: **Owner** (the author; final decisions and taste). **Lead** (ChatGPT; coordination, technical and scope review, decision log). **Design** (Claude in this phase; creative and design proposals). **Implementer** (one per package, assigned by the Lead). **Reviewer** (a separate session or person who did not write the thing).

---

## 2. Level one: the manual workflow, now

One encounter and one environment, made by hand, with no generators.

| Discipline | Input | Work | Concrete output | Owner / role | Depends on | Acceptance evidence | If it fails, go back to |
|---|---|---|---|---|---|---|---|
| **Gameplay** | Slice design §4 | Play the encounter with real cups and paper, then as a flat interactive mock-up | Rules sheet v1; record of what 3 or more testers did first | Design, with Owner as first tester | Route selected | Testers find Join or Set against without being told, and can say why it worked | Slice design §4 (the body of the question) |
| **Gameplay** | Rules sheet v1 | Grey-box the encounter with primitive shapes | Playable test scene; data file for two instances | Implementer | Engine chosen; rules sheet | All roads in slice §4.3 completable; second data instance works with no code change; one result per encounter | Rules sheet |
| **Environment art** | The drawing; scene recipe §7 | Anchors, blockout, camera checks | Blockout scene; five captured views beside the drawing | Implementer, reviewed by Owner | Engine chosen | Owner agrees the limbs read as arms and hands in all five views, untextured | Scene recipe (proportions, anchors) |
| **Environment art** | Approved blockout | Model one hand, one forearm section, tea objects; apply graphite look | Small asset set; look-test captures | Implementer; Owner for taste | Blockout approved | Six-point comparison with the drawing (form, scale, composition, texture, light, mood) recorded | Blockout if form is wrong; materials if only surface is wrong |
| **Narrative** | Slice §3, §5 | Write the few lines; define the four worksheet states and the two traces | One page of text; four sheet images; prop placement list | Design; Owner approves voice | Route selected | Owner reads it aloud and nothing sounds like a lesson | Creative proposal §3 to §4 (thesis, pillars) |
| **UI** | HUD handoff; slice §8 | Implement retained elements; add temporary encounter prompts | HUD that shows state and sends action requests only | Implementer | State and action names agreed with gameplay | Time jump, bar change and prompts shown from real state; no rule lives in the HUD | Slice §8, or the handoff's open questions |
| **Engineering** | Slice §4.6, §5 | Rules layer for health, time, result; scene switch with a return point | Small state module with tests | Implementer; Lead reviews | Engine chosen | A result applied twice changes nothing the second time; return restores the right place and time | Data contract |
| **Integration** | All of the above | Join reality room, switch, encounter, return, free slot, morning | One build of the slice | One Implementer for the joined scenes; Lead reviews | Every row above accepted | Three outside players finish it; hesitations logged; Owner signs the look | The row whose evidence failed |

---

## 3. The art chain, with its checks

references → visual grammar → scene recipe → composition anchors and blockout → reusable anatomy and ordinary objects → graphite materials and lighting → engine views → review

| Step | Check before moving on |
|---|---|
| References → grammar | Every rule cites a drawing. Observation and invention are listed separately |
| Grammar → recipe | The recipe names what is added for play and why |
| Recipe → blockout | **Readability:** hands and forearms recognisable from five views with no material. **Composition:** the entry view overlays the drawing's main masses |
| Blockout → play space | **Navigation:** every interaction point reachable in every arm position. **Collision:** the student cannot leave the pale area, be trapped by a sweep, or pass through a limb. **Camera:** no clipping into limbs; stacks stay in frame |
| Anatomy and objects | **Provenance log:** for each asset, who made it, from what, with which tool, under what licence. Anything derived from the owner's drawings is marked as such. Purchased or generated assets are recorded before they enter the project |
| Materials and light | Gesture warnings remain legible in greyscale. The student remains findable at all times |
| Engine views → review | Captures are from the running scene, never concept images. The Owner decides taste; the Reviewer checks the list above |

Image generation may help explore surface and light. It does not replace walkable geometry and it does not enter the provenance log as an asset unless a file from it ships.

---

## 4. Level two: automate only after the manual pass works

| Repeated step seen in level one | Worth automating when | Not before |
|---|---|---|
| New data instances of a question type | Already data from day one | — |
| Capturing the five check views | A second room exists | One room is quicker by hand |
| Placing many limbs along curves | A second room needs a stack | The first stack is placed by hand to learn the rules |
| Posing hands into the gesture set | Three or more hands need the same gestures | — |
| Worksheet handwriting states | A third question type exists | — |

Not proposed at all for now: procedural rooms, trained image models, asset services, a question generator.

---

## 5. First work packages

WP3 requires passed tabletop and flat mock-up checks, approved Rules sheet v1, and an accepted WP2. Early WP4 work requires separate approval and is limited to anchors, limb stacks and camera. Arena dimensions wait for WP1. WP9 validates the small Taoshe slice; the W16 gate remains in PRODUCTION_ROADMAP.md.

For generated or third-party files imported as project assets, record source, author or generation tool, version, and usage rights on import. Keep exploratory concept references labeled as such, and verify provenance again before shipping. ComfyUI is optional and needs a recorded workflow only when adopted for a reproducible production step.

| ID | Package | Output | Needs | Can run independently? | Acceptance |
|---|---|---|---|---|---|
| WP0 | Decisions | Route chosen; answers to the questions in §8 | Owner | First | **Answered by the Owner on 15 Nov; entered as D010–D014 in DESIGN_DECISIONS.md on 15 Nov, Lead to confirm** |
| WP1 | Tabletop and flat mock-up test of "Two trays" | Rules sheet v1; test notes | WP0 (route) | Yes, needs no engine | See §2 row 1 |
| WP2 | Engine choice and empty project under version control | A project that opens and builds an empty scene | Lead | Yes | Built once on the owner's machine; version recorded |
| WP3 | Encounter grey-box | Test scene; data file; state module | WP1, WP2 | After WP1 | See §2 row 2 |
| WP4 | Gray Space blockout and camera | Blockout scene; five views | WP2. The arena size comes from WP1 | Anchors and stacks can start before WP1 ends | See §2 row 3 |
| WP5 | Hand, forearm and tea objects v0; provenance log | Asset set | WP4 approved | No | Reads as the drawing's hands in the blockout |
| WP6 | Graphite look test | Captures with six-point notes | WP5 | No | Owner's approval |
| WP7 | Reality room grey-box, return, worksheet states, free slot, morning | Playable reality scene | WP2; text from narrative | Yes, in parallel with WP3 to WP6 | Return shows the right time and sheet for each result |
| WP8 | HUD: retained elements plus temporary prompts | HUD reading real state | State names from WP3 and WP7 | After those names are fixed | See §2 UI row |
| WP9 | Integration and slice playtest | One build; playtest log | All | No | See §2 last row |

**Same owner required, to avoid scene conflicts:** WP3 works in its own test scene with primitives. WP4 to WP6 share the Gray Space environment scene and need one implementer at a time. WP9 merges them and needs a single implementer for the merged scenes.

**Needs the route selected:** WP1, WP3, WP7, WP8. **Does not:** WP2, and the anchor and stack part of WP4.

---

## 6. How the documents should grow

The owner's prompt asks for a project file structure. The folder already has one, and its rule is right: do not create empty documents. I propose it grows only when a package produces something.

| Document | Created when | Holds | Core (changed only by the Owner) | Free to iterate |
|---|---|---|---|---|
| `README.md`, `GAME_MASTER.md`, `DESIGN_DECISIONS.md` | Exist | Entry, baseline, log | Creative core, roles | Stages, wording |
| `ART_DIRECTION.md` | Exists | Visual grammar | Limbs, scale, bright reality | Production path |
| `CREATIVE_PILLARS.md` | When a route is chosen | Thesis and pillars, lifted from the creative proposal | All of it | Examples |
| `CORE_LOOP.md` | After WP1 | The three loops, corrected by the test | Understand, force, leave | Every number |
| `02_design/QUESTION_TYPES/<type>.md` | One per type, after its test | Body, behaviour, operations, data | Operations are truthful | Tuning |
| `01_art/SCENES/<room>.md` | One per room, from its recipe | Observed, added, anchors, checks | The source drawing | Proportions |
| `03_narrative/` | When a second day is written | Mapping table, text | Nothing is given a meaning without the Owner | Lines |
| `05_production/PROVENANCE.md` | With the first asset | Asset origins | — | — |

I have not created any of these. The owner's prompt also asks for five foundation files; three already exist under the Lead's governance, and I have not replaced them. The content for the other two is in `CREATIVE_PROPOSAL.md` §3 to §5, ready to be lifted out once a route is chosen.

---

## 7. The three uncertainties that matter most

| # | Uncertainty | Smallest experiment | What a result changes |
|---|---|---|---|
| 1 | Do players *work out* the operation, and does the encounter play as a fight? (The Owner has accepted the no-striking form in principle) | WP1: two paper trays, three cups, coins for weight, one person playing the hands. Then a flat mock-up with the sweep on a timer | If players only guess: add a third tray, or change the body. If it feels like a puzzle and that is unwanted: add a way to act on the hands themselves, or reconsider Route B. Either sends work back to the slice design before any engine work |
| 2 | Do the limbs read as limbs in three dimensions, from behind the student and from the side? | WP4 with untextured shapes and one rough hand; five views beside the drawing | If not: change proportions and gesture clarity, limit camera freedom, or stage the stacks as layered planes seen from a narrower arc. This changes the asset list in WP5 |
| 3 | Does the unscored choice feel meaningful, or just unrewarded? | Read the return and the free slot aloud to three people as a paper walk-through, with the bars drawn by hand; ask what they chose and why | If it feels empty: strengthen the trace left in the world, not the reward. If people choose by guessing at hidden numbers: remove the remaining cues. This changes the narrative row and nothing else |

Results from WP1 and WP4 should be allowed to reorder this pipeline. If WP1 fails twice, the right move is to stop environment work and return to the creative proposal.

---

## 8. Questions put to the Owner, and the answers

All five were answered on 15 Nov 2026. The full table is at the top of `CREATIVE_PROPOSAL.md`.

1. Route: **A now, with B's triage later.**
2. A fight won by making a hand let go, with no striking: **yes.**
3. `sipping_mountain_front` is the Taoshe tea room, and a student could study there: **yes.**
4. Questions as arrangements held by hands, no creatures: left to Claude; **adopted.**
5. The student keeps some colour in the Gray Space: left to Claude; **adopted, muted, pending the look test.**

Still open: one room per author drawing; engine choice; who implements.

---

## 9. Self-review

- **Unsupported tool assumptions:** removed. No row presumes an engine, a modeller, or that either assistant can build and run the game. WP2 exists to find out.
- **Excess scope:** ten packages is many for one slice. WP1, WP2 and WP4 are the only ones that should begin after the route is chosen; the rest wait on their results.
- **Contradiction:** WP4 can start before WP1 ends, but the arena size comes from WP1. Resolved by limiting the early part of WP4 to anchors, stacks and camera.
- **Unclear ownership:** the Implementer is unnamed throughout. That is deliberate and is the Lead's to assign.
- **Visual drift:** the chain blocks material work until untextured form is approved, which is the baseline's own test.
- **Not independently reviewed.**
