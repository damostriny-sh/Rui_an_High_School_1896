# WP1 · "Two trays" tabletop test kit

Sprint task: S1-03. Status: **ready to run; no test has been run yet.**
Prepared by Claude, 15 Nov 2026, from `FIRST_SLICE_DESIGN.md` §4 and `PRODUCTION_PIPELINE.md` §7 (uncertainty 1).

## 1. What this test answers

1. Do players **work out** an operation (Join or Set against) by looking, without being told any maths?
2. Can they say **why** it worked?
3. Does it feel like a **fight**, a **puzzle**, or a **quiz**?
4. Does the second instance go faster? That would show they recognised the type.

It does not test art, camera, the free slot, or exact numbers. The numbers here are starting values to try, not tuning.

## 2. People

- **Facilitator** (the owner): plays the hands, runs the timer, says only the lines in §6.
- **Recorder** (optional second person): fills in the record sheet. If you test alone, film the table instead, with the tester's permission, and fill in the sheet from the video.
- **Testers**: at least 3 people who have **not** read the design documents. Students or recent students are best. Test one at a time, and don't let the others watch.

**Your own dry run doesn't count.** You know the solution. Run it once by yourself, playing both sides, to check that the procedure flows and the materials work. Then test real players.

## 3. Materials

| Item | Quantity | Stands for |
|---|---|---|
| Large paper (A3) or masking tape on a table, marked in an 8 × 5 grid of squares about 6 cm each | 1 | The pale tray area |
| Small plate or square of card that fits one square | 2 | Tray A, Tray B |
| Identical small cups, each with a paper cap on top | 3 | The covered cups (the unknown) |
| Binder clip | 1 | The small hand pinching the answer cup shut |
| Hand outline cut from paper, about cup size | 2 | Small hand pressing down on A; small hand pushing up under B |
| Blank cards and a marker | about 10 | The numerals that appear on pans |
| Pawn (a game piece or bottle cap) | 1 | The student |
| Coins | 10 | Health |
| Phone with a metronome at 60 bpm | 1 | Walking pace |
| Second phone or a timer | 1 | Stopwatch and sweep timer |
| Record sheet (§8), one per tester | 3+ | — |

## 4. The board

Columns 1–8 run left to right. Rows 1–5 run far to near.

```
         c1    c2      c3    c4      c5      c6    c7      c8
row 1  |    |      |      |  [CUP + clip]  |      |      |    |   <- answer point (on the line between c4 and c5)
row 2  |    |      |      |       |       |      |      |    |
row 3  |    |TRAY A|      | PAN L | PAN R |      |TRAY B|    |   <- tray row; trays slide only along it, between c2 and c7
row 4  |    |      |      |       |       |      |      |    |
row 5  |    |      |      |   P   |       |      |      |    |   <- near edge = Leave edge; P = pawn start (c4)
```

Columns 1 and 8 are margins the pawn can walk in, so that it can get behind a tray to push it inward. From its start, each tray needs 2 pushes to reach the nearer pan and 3 to reach the farther one: 4 pushes to Set against, 5 to Join.

Setup:
- **Tray A** at row 3, col 2. One capped cup on it. Card **"7"** under its edge. The paper hand lies **on top** of the tray, pressing.
- **Tray B** at row 3, col 7. One capped cup on it. Card **"1"** under its edge. The paper hand sticks out **from under** the tray, pushing up.
- **The two arms:** the facilitator's left hand rests in a fist at the left edge of the board beside row 3, and the right hand at the right edge. A fist is a **grip**.
- **Answer cup:** the third capped cup sits on the line between col 4 and col 5 of row 1, its cap held on with the binder clip.
- **Pan L** is row 3 col 4; **Pan R** is row 3 col 5. Mark them.
- **Pawn** at row 5 col 4. **10 coins** next to the tester.

## 5. Rules v0 (the facilitator applies these; the tester is not told them)

**Pace.** The metronome runs at 60 bpm. On each beat the tester may take **one action**. Doing nothing is allowed.

| Action | How | Effect |
|---|---|---|
| Move | Move the pawn one square, orthogonally | — |
| Push | The pawn must be in row 3 directly beside a tray. Say "push" | The tray slides one square away from the pawn along row 3. A tray can't leave row 3 or enter col 1 or col 8. Two trays may share a square (stacked) |
| Study | Say "study" and don't move | After **3 study beats in a row**, on every further study beat the facilitator taps **both paper hands at the same moment**: the hint that they mirror each other |
| Answer | The pawn is in row 2, col 4 or 5. Say a number | Right: remove the clip, encounter ends (**Released**). Wrong: tester loses **2 coins** |
| Leave | The pawn is in row 5. Say "leave" on **3 beats in a row** | Tester loses **4 coins**; encounter ends (**Left**) |
| Pick up / put down a card | The pawn is on or beside the card's square | Carries one result card (used in Set against) |

**What placements do** (all legal, all truthful). Apply these the moment the condition is met:

| Situation | Facilitator does |
|---|---|
| One tray on a pan, the other not | Nothing new. The tray still shows its own card (7 or 1) |
| **Both trays on the same pan** (Join) | Lift both paper hands off together (they clasp and withdraw). Put a card on that pan: **"8"**, and a small **"4"** beside each cup. Sweeps stop |
| **Trays on opposite pans** (Set against) | Lift both capped cups off the trays together and set them aside (they cancel). Put a card **"6"** between the pans and a small **"3"** card beside each paper hand. Sweeps stop |
| After Set against, the tester carries a "3" card to Tray A | Remove A's pressing hand. Replace A's card with **"4"** |
| After Set against, the tester carries a "3" card to Tray B | Remove B's lifting hand. Replace B's card with **"4"** (1 + 3) |

The tester never sees x, y, + or =. Don't say "add", "subtract", "equation" or "unknown".

**Sweep: the conditions won't stay together.**
- Start a repeating 30-second timer when the tester's first beat begins. Before the test, roll a die for each cycle to vary it slightly if you like: 1–2 → 25 s, 3–4 → 30 s, 5–6 → 35 s.
- **3 seconds before** each sweep, open both fists into a **point** (index finger out). This is the only warning.
- At the sweep, for each tray **not on its starting square**, slide it back along row 3 to its start. Every square it crosses is the path.
- If the pawn is on the path: tester loses **1 coin**, and the pawn moves one square toward row 5.
- Return to fists. Sweeps stop for good once a Join or Set against has happened.
- **Assist** (only if a tester asks, or is clearly overwhelmed): use 45 s. Note it on the sheet.

**Collapse.** At 0 coins the encounter ends (**Collapsed**). Note it, then let the tester replay the encounter if they want; the replay is not counted.

## 6. Facilitator script

Say only these lines. Answer any other question with: "What do you think? Try it." / 「你觉得呢？试试看。」

**Before instance 1**
> "This is a place inside someone's head while they do homework. The small figure is you. The hand at the top is holding that cup shut. Your goal is to make it let go."
> 「这是一个人写作业时脑子里的地方。这个小人是你。上面那只手捏着那个杯子不放。你的目标是让它松手。」

> "On each beat you can do one thing: move one square, push a tray when you're beside it, study by standing still, answer a number at the top, or leave from the bottom edge by holding 'leave' for three beats. The coins are your health."
> 「每一拍你可以做一件事：走一格；站在托盘旁边时推它；原地不动“观察”；在上方说出一个数字作答；或者在最下面一排连续三拍说“离开”。硬币是你的体力。」

> "Please think aloud while you play."
> 「玩的时候请把你的想法说出来。」

Start the metronome and the timers.

**Between instances**: reset the board with the instance 2 cards (§7). Say:
> "Another one."
> 「再来一个。」

Say nothing else. Whether they recognise the type is what's being tested.

**After both instances**, ask these and write the answers down word for word:
1. "What was going on in there?" / 「刚才那里面发生了什么？」
2. "What made the hand let go? Why did that work?" / 「是什么让那只手松开的？为什么有用？」
3. "Did that feel more like a fight, a puzzle, or a test question? Why?" / 「刚才更像一场战斗、一个谜题，还是一道考题？为什么？」
4. "Did you think about leaving? When?" / 「你有没有想过离开？什么时候？」
5. "Was anything confusing or unfair?" / 「有没有什么地方让你困惑或觉得不公平？」

Finally, show them the two equations on paper (instance 1: `x + y = 7`, `x − y = 1`) and ask: "Does this remind you of anything you did?" / 「这让你想到刚才做的什么吗？」 Note whether they connect it on their own.

## 7. Answer card (facilitator only; keep it face down)

| | Instance 1 | Instance 2 |
|---|---|---|
| Tray A card | 7 | 9 |
| Tray B card | 1 | 3 |
| Answer (the cup) | **4** | **6** |
| Join: pan card / each cup | 8 / 4 | 12 / 6 |
| Set against: middle card / each hand | 6 / 3 | 6 / 3 |
| After carrying 3 to Tray A | A reads 4 | A reads 6 |
| After carrying 3 to Tray B | B reads 4 | B reads 6 |

## 8. Record sheet (one per tester)

Tester code: ____  Age / school stage: ____  Plays games? never / sometimes / often  Assist on? yes / no

| | Instance 1 | Instance 2 |
|---|---|---|
| First action (what, which beat) | | |
| First placement: one tray / Join / Set against | | |
| Was that placement deliberate (said why) or a try? | | |
| Studied? How many beats in total | | |
| Read the share from the cards (yes / no) | | |
| Wrong guesses (count, numbers said) | | |
| Sweeps hit | | |
| Ending: Released / Left / Collapsed | | |
| Road: Understand (Join) / Longer road (Set against + carry) / Force (guessing) / Leave | | |
| Total time (stopwatch) | | |
| Coins left | | |
| Hesitations: when, and what they said | | |

Answers to the five questions and the equation question: (write verbatim)

## 9. Reading the results

Fill in after all testers:

| Question | Count | Result |
|---|---|---|
| Testers who reached Join or Set against **deliberately** in instance 1 | __ / __ | |
| Of those, could explain why it worked | __ / __ | |
| Solved instance 2 noticeably faster, with a deliberate first placement | __ / __ | |
| Said "fight" / "puzzle" / "test question" | __ / __ / __ | |
| Used Leave at least once | __ / __ | |
| Collapsed | __ / __ | |

**Decision rule** (from PRODUCTION_PIPELINE.md §7):
- **Go on to the flat mock-up (S1-04) ** if at least 2 of 3 testers found an operation deliberately and could explain it. Start WP3 engine grey box only after the tabletop and flat mock-up pass and Rules sheet v1 is approved.
- **Revise the body, then run another round** if most testers reached a placement only by trying both, or only guessed. First fix to try: add a third tray that shares nothing with the other two.
- **Discuss the form with the owner** if most say "puzzle" or "test question" and that feels wrong. Possible changes: give the player a way to act on the hands themselves, or look again at Route B.
- **Stop the Gray Space blockout (S1-06) and return to the creative proposal** if two rounds in a row fail the first test.

Also check:
- **Leave's cost.** If nobody ever leaves, or everybody leaves, it is mispriced. It should sit between understanding and guessing.
- **Sweep timing.** If it hits too often, or never matters, change the interval.
- **Hint timing.** Note whether the hand tapping came too early or too late to help.

## 10. After the test

1. Write **Rules sheet v1** into this folder as `WP1_RULES_V1.md`, starting from §5 and changing only what the results justify. Put the reason beside each change.
2. Add the completed sheets, or a summary of them, to this folder as `WP1_RESULTS_ROUND1.md`.
3. Update S1-03 in `docs/00_project/CURRENT_SPRINT.md` with the outcome and the decision taken under §9.

## 11. Known gaps in this test

- **Stopping sweeps after a combination** is a test rule. The slice design doesn't say what the arms do once the trays are combined.
- **The grid and the metronome** are paper stand-ins for walking. They make exposure to sweeps countable, but they will feel more deliberate than real-time movement.
- **One person plays three hands.** The sweep warning is the facilitator's own fist opening, so it may be read from their face as much as from their hand. Watching the tester's eyes helps.
- **Coin costs** (1 per sweep hit, 2 per wrong guess, 4 to leave, 10 to start) follow the design's ratios, not any tested balance.

## 12. Variants to capture for Rules sheet v1

Record the reason and observed effect of post-combination sweeps, substitution on either tray, Assist timing, Leave elapsed time versus school-time charge, and collapse precedence. Note deliberate combinations, mixed paths and forced guesses separately so the engineering contract can classify outcomes without guessing at player intent.
