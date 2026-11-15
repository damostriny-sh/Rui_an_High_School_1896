# FIRST_SLICE_DESIGN

Status: **proposal; Route A selected by the owner on 15 Nov; details not yet approved**. Develops Route A from `CREATIVE_PROPOSAL.md` only. Author: Claude. Date: 15 Nov 2026.

Labels: **[Confirmed]**, **[Observed]** (seen in a reference), **[Proposal]**. Every number is a starting value for testing, given as a range where I cannot justify a single figure.

---

## 1. What this slice has to prove

One table in reality, one table in the Gray Space, one question type, one free choice. If it works, a player will be able to say three things afterwards without being told:

1. "I worked out what to do by looking at it."
2. "When I came back, time had gone and the page showed how I had done it."
3. "Nobody told me what the last ten minutes were for."

Provisional length: 10 to 15 minutes for a first play. Unverified.

---

## 2. Fiction and system, side by side

| Fiction | System |
|---|---|
| The student is doing a worksheet at a long table in the evening | A reality scene with one interactable worksheet |
| The room drains to grey; the table is enormous; hands hold the question | Scene switch to the encounter; reality's clock stops being shown as moving |
| The question holds two trays apart and pinches the answer shut | Encounter state with two statement objects, one target, three verbs |
| The student pushes, joins, answers, or tears free | Operations that transform the state; a result is emitted once |
| The student is back at the table; it is later; the line is written | Return with elapsed time applied and one of several worksheet states shown |
| A cup of tea beside the sheet has been poured and is cooling | One free slot with three options, two of them unscored |
| In the morning the sheets are collected | A fixed consequence beat reading the result and the choice |

The Gray Space places and the reality places are different scenes that share one anchor object: the table.

---

## 3. The sequence

1. **Reality, evening.** The Taoshe room: wooden walls, a long dark table, paper cups, a kettle. The student sits with a worksheet of two questions. The retained HUD is quiet: map and time label only. Interact with the sheet.
2. **Switch.** No flash. Colour leaves the room from the edges inward over about two seconds while the table grows. The last coloured thing is the student, who keeps a muted trace of colour throughout the Gray Space (my call under the owner's delegation; judged in the look test).
3. **Entry view.** The camera holds the drawing's composition for 2 to 3 seconds, then comes down behind the student, who stands on the pale tray at the centre of the table.
4. **Encounter** (section 4).
5. **Return.** Colour comes back the same way. The time label has jumped. The worksheet shows what happened. The bars appear briefly if they changed.
6. **Free slot.** One slot remains before the bell. Three things can be done; only one can be chosen (section 5).
7. **Morning.** Sheets are collected. One line from the collector, one from the person across the table. End of slice.

---

## 4. The encounter: "Two trays"

Question type: *two conditions that share one unknown*. First instance: `x + y = 7`, `x − y = 1`, find `x`. Second instance, same body, different data: `x + y = 9`, `x − y = 3`.

### 4.1 The body

| Part of the question | In the Gray Space |
|---|---|
| The unknown `x` | A covered cup. The same cup stands on both trays, visibly identical |
| Condition A | A tray held at its rim by the arm that reaches in from the left |
| Condition B | A tray held by the arm that reaches in from the right |
| `+y` in A | A small hand pressing down on tray A |
| `−y` in B | An identical small hand pushing up from under tray B |
| The totals 7 and 1 | What each tray weighs, shown as a numeral on the pan it rests on |
| What is asked | A third cup, same shape, its lid pinched shut by the small hand that hangs over the centre |
| The place to combine | A two-pan balance at the centre of the tray area |

The player never sees `x`, `y`, `+` or `=`. The worksheet in reality carries the written equations; the Gray Space carries their shape.

### 4.2 Player intention and verbs

The player wants the pinching hand to let go.

| Verb | What the player does | What the world does |
|---|---|---|
| **Move** | Walk on the tray area | — |
| **Study** (hold) | Stop and look | Camera rises to the drawing's view. Time keeps running. After several seconds the two small hands begin to mirror each other's motion |
| **Push** | Lean on a tray to slide it to a pan of the balance | The holding arm lets the tray go slowly, and will take it back at the next sweep |
| **Join** | Put both trays on the *same* pan | The pressing hand and the lifting hand meet, clasp, and withdraw. The pan reads 8 for two cups, and marks each cup's share: 4 |
| **Set against** | Put the trays on *opposite* pans | The two equal cups lift away together. One hand pushes down against one pushing up; the balance reads 6 between them, 3 each. The player can then carry that 3 to tray A, where the pressing hand lifts off and the pan reads 4 |
| **Answer** | At the pinched cup, set a number and confirm | Right: the pinch opens. Wrong: the hand strikes the student |
| **Leave** (hold, at the table's near edge) | Walk out | Fingers close across the edge; the student pushes through |

Join and Set against are not menu items. They are where the player puts the second tray.

### 4.3 Three ways through

| Way | Steps | Cost |
|---|---|---|
| Understand | Join, then answer | Little time, no health unless caught by a sweep |
| The longer true road | Set against, carry the result back, then answer | About twice the time; more exposure to sweeps |
| Force | Answer by guessing | Health for every wrong guess; some time |
| Leave | — | A fixed health cost, about that of two wrong guesses; no time; the line stays blank |

Leaving must be cheaper than blind guessing and dearer than understanding, or triage means nothing. The exact values are for the prototype to find.

### 4.4 Pressure

One behaviour, derived from the type: *the conditions will not stay together.* Every 25 to 35 seconds the two holding arms take their trays back to where they started and drag across the tray area as they go. A student in the path is knocked down and loses a little health.

The warning is a gesture, not a coloured marker: the holding hand changes from a grip to a point 2 to 3 seconds before it moves. An assist setting lengthens both intervals and changes nothing else.

Only the two table arms and the pinching hand belong to the question. The great stacks of limbs around the scene never strike.

### 4.5 Information and feedback

- Numerals appear only on the pans and at the answer. Nothing floats over the student.
- There is no "correct" sound. The world changes and the player reads it.
- Hints cost time, not points: longer study makes matching parts move alike. In reality, a hint can be a gesture seen on a blackboard or in a notebook, never a solution.

### 4.6 States and results

`Entry → Held → (Joined | SetAgainst | Substituted) → Released`, with `Left` and `Collapsed` reachable from any state except during a combining animation.

- **Released:** answered. Result records which road was taken.
- **Left:** skipped. Fixed health cost, applied once.
- **Collapsed:** health reached zero. The student comes to at the table with the bell already rung: the free slot is lost. No death, no retry prompt inside the fiction. For testing only, the prototype may offer a restart of the scene.

Each encounter emits exactly one result. Health, time and the mark are applied by the rules layer, not by the scene or the HUD.

---

## 5. Return, recovery and the choice

**Return.** Time in the Gray Space is charged to the evening: roughly 5 to 10 minutes of school time per minute inside. The time label is how the player learns this.

**The page.** The worksheet shows one of four states, in the student's handwriting: a single clean line; a longer working with one part struck through; a row of crossed-out guesses and a final answer; a blank. The school will read only whether there is an answer. The page remembers how.

**The free slot.** One choice, three options:

| Option | Scored by the school | Effect |
|---|---|---|
| Do the second question | Yes | Another encounter of the same type. A player who understood ends it in one move. This is what learning looks like in this game |
| Drink the tea with the person across the table | No | Restores. A short exchange about nothing in particular |
| Sit by the window alone until the bell | No | Restores, differently |

**Why this is a choice and not arithmetic.**
- The game shows no preview of what an unscored option gives. The bars move afterwards; there is no number.
- The two unscored options are not ranked. They differ in what they leave behind: a second cup on the table the next morning, or the window left open.
- Choosing either leaves question two blank, and the morning will say so. The game does not console the player for it.
- What was chosen appears once in the Gray Space the next time the student is there, as the one object no hand is holding. It does nothing. **[Proposal]**

---

## 6. How the two worlds act on each other

| Reality → Gray Space | Gray Space → reality |
|---|---|
| The written question decides the body | The road taken decides the handwriting on the page |
| Health carried in is the health you fight with | Health lost is carried back |
| An unscored act appears as an unheld object | Time spent inside is taken from the evening |
| | The cup the student stood beside is the cup now at their elbow, moved a hand's width. This is the slice's single crack |

One crack only. Reality must stay ordinary for the crack to register.

---

## 7. Scene recipe: `sipping_mountain_front`

The drawing is the source. Where the game needs something the drawing does not show, it is listed as an addition.

### 7.1 Observed in the drawing

- **Two stacks of long limbs**, left and right, layered one above another and running from the picture's edges toward the centre. About eight on the left, each ending in a hand whose index finger points inward. About ten on the right, hands hanging from a ridge with fingers curled downward. One hand from the right reaches further than the others, pointing down into the gap.
- **A dark wedge** between the stacks, widest at the bottom, narrowing upward to a pale opening at the top.
- **A rounded dark block** at upper right. I cannot tell what it is.
- **A table** at lower centre: dark, rounded-triangular, on a single dark triangular foot, with a paler raised or sunken area in the middle.
- **Two long arms in the foreground**, one entering from the lower left and one from the right, both ending on the pale area. The left hand rests on a small round object.
- **A small hand above the centre of the table**, wrist up, fingers down, pinching a small dark object.
- **Two small cups** on the pale area. **Four small mushroom-shaped forms** on the dark rim. **Three stool-like pedestals** standing off the table.
- **A small splayed hand** on a limb at lower right.
- Soft graphite tone, visible paper grain, uneven edges. No colour.

**Confirmed by the owner, 15 Nov:** the drawing corresponds to the long tea table in `inside_the_taoshe_building.JPG`, and a student can plausibly study there. The Taoshe room is the reality side of this scene, and that photo is its reference.

### 7.2 Proposed additions for play

- The two trays, the two small tray hands, and the central balance. These do not appear in the drawing. They sit inside the pale area and use tea-table forms.
- A ground surface for the area the student walks on.
- The far sides of everything. The drawing gives one view; backs of limbs, the reverse view and what lies past the picture's edges are designed, not observed. Proposal: limbs run off into paper-white haze. **No shoulders, torsos or faces are added.** Whose arms these are stays unanswered.

### 7.3 Scale hierarchy (starting proportions, student = 1)

| Thing | Rough size |
|---|---|
| Student | 1 |
| Cups | 1 to 1.5 high |
| Pale tray area (the walkable arena) | 20 to 35 across |
| Whole table | 2 to 3 times the tray area |
| The two table arms | forearm about 6 to 10 thick |
| One limb in a stack | 30 to 60 thick, running several hundred long |
| The wedge and the opening | taller than everything else in frame |

Placing the student at cup scale on the table is my proposal. The drawing shows no person.

### 7.4 Anchors

| Anchor | Content |
|---|---|
| **Focal** | The pinching hand and the cup under it, at the centre of the pale area |
| **Foreground** | The two table arms crossing the lower frame; the three pedestals |
| **Limb** | Left stack (pointing), right stack (hanging), the one far-reaching hand |
| **Player** | Starts at the near edge of the pale area, facing the wedge |
| **Background** | The dark wedge, the pale opening, the unidentified block (kept as a shape, not interpreted) |

### 7.5 Navigable space

The pale area only. Its rim is the boundary. The dark part of the table is a margin the student cannot cross except at the near edge, which is the Leave point. Nothing is climbed. Tray paths, the balance and the answer point must all be reachable with the two arms in every position of their sweep.

### 7.6 Camera

- **Entry and Study:** the drawing's viewpoint, high and frontal.
- **Play:** follows behind the student. Pitch is limited so that the stacks stay in the upper part of the frame and the horizon never drops out of it.
- **Checks to run:** the drawing's view, behind the student, each side, and looking back from the wedge. At each, the limbs must still read as arms and hands with the graphite material switched off.

---

## 8. The retained campus HUD in this slice

| It can support | How |
|---|---|
| Health and sanity bars, top left | Appear on return when a value changed |
| Time label | Shows the jump on return. This is the slice's main use of the HUD |
| Place name | On entering the room |
| Interaction signal and hold list | The worksheet and the three free-slot options |

**Missing and needed:** prompts for the encounter verbs; a number entry for Answer; a hold indicator for Leave; any Gray Space treatment of the HUD.

**Keep temporary:** encounter prompts reuse the key-cap component in off-white only. The map is hidden in the Gray Space. The time label stays visible there but does not advance. No final encounter HUD is designed in this slice.

**Not canonical:** the handoff's "Period 6", the exam countdown line, the librarian, the map drawing and the key letters are sample content.

---

## 9. Minimum bounds

| Category | Bound |
|---|---|
| Scenes | 2: one reality room, one Gray Space room |
| Question types | 1, with 2 data instances |
| Student | 1 figure; walk, push, knocked down, sit |
| Other people | 1 seated figure with no name and two or three lines; 1 voice for the collector |
| Gray Space bodies | 2 table arms with 2 gestures each; 1 pinching hand with 3 poses; 2 small tray hands; the two stacks as scenery |
| Objects | Table, 2 trays, 3 cups, balance, pedestals |
| Reality objects | Table, chairs, cups, kettle, worksheet in 4 states, window |
| Interactions | Study, push, join or set against by placement, answer, leave; sheet; 3 free-slot options |
| Encounter states | 8 (section 4.6) |
| Not included | Saving, timetable, rank, sanity effects, map content, second room, any other character |

I have no basis for a time or cost estimate and give none.

---

## 10. Self-review

- **Rule conflict:** "the player never computes" against "set a number to answer". After Join the pan shows each cup's share, so the understanding player reads the answer and repeats it. Only the guessing player chooses a number unaided. Accepted.
- **Is the decision real?** With two trays there are two placements. If testers always try Join first by chance, the type does not test understanding. Mitigation to test: a third tray that shares nothing with the others. Not added until a test shows the need.
- **Is it a fight?** There is pressure and injury but no striking back. The owner confirmed on 15 Nov that this is the fight wanted. Whether it *plays* as one is still for the first test.
- **Visual drift:** trays, balance and numerals are additions, and numerals on a pan are the nearest thing to UI in the world. If they look foreign, tally marks are the fallback.
- **Scope:** the unheld object and the moved cup are each one prop placement. The four worksheet states are four textures. I have kept every narrative effect at that size.
- **Assumption now settled:** study in the Taoshe room is plausible school life (owner, 15 Nov).
