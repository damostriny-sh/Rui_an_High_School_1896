# SLICE_NARRATIVE — outline and text for the first slice

Sprint task: S1-07 (also covers the roadmap's W2 "narrative outline" at slice scale). Status: **proposal, awaiting the owner's read-aloud check.** Author: Claude, 15 Nov 2026.
Built on `FIRST_SLICE_DESIGN.md` §3 and §5 and decisions D010–D012. Labels: **[Confirmed]**, **[Proposal]**.

Chinese is the primary text. English is a separate version, not shown with the Chinese on the same screen. Every line is a starting draft for the owner to rewrite in their own voice.

---

## 1. Outline (slice scope only)

**Situation [Proposal].** Evening self-study (晚自习) in 陶舍 [Confirmed: D012]. The student, who is the player and has no name, sits at the long tea table with a two-question exercise sheet. Across the table sits one other student, also unnamed, doing their own work. Nobody supervises. The next morning a classmate who collects the sheets passes by.

**Cast.** Three people, all unnamed and none modelled on a real person:
| Who | Role in the slice | Lines |
|---|---|---|
| The student (player) | Does the sheet, enters the Gray Space, chooses the free slot | 1 |
| The person across the table (对面的人) | Present the whole evening. Saw how you worked | 2 in the evening if you have tea; 1 in the morning |
| The collector (课代表) | A classmate doing their assigned job. Not a teacher, not a villain | 1 in the morning |

**Beats.**
1. **Evening.** The room is warm and lit. Two people, two sheets, a kettle. Quiet.
2. **The question.** Opening the sheet starts the switch. No line is spoken.
3. **The Gray Space.** No words at all, only paper, graphite and breath (CREATIVE_PROPOSAL §4).
4. **Return.** The time has jumped, the page shows how you worked, and the cup has moved a hand's width. No line.
5. **The free slot.** Three options, no previews. The tea option holds the only conversation of the evening.
6. **Morning.** One line from the collector about what the school can see. One line from the person across about what only they saw.

**What the slice says, without saying it.** The school counts answers. A person noticed the working. The free slot was yours, and nothing tells you whether you spent it well.

**Left open on purpose.** Who the student is, why they study here, who the person across is, what the Gray Space is, what the hands mean. Nothing in this slice answers any of these. A later outline for the whole game needs the owner's direction first (CREATIVE_PROPOSAL §1, "Open").

---

## 2. Rules for all text

- No line explains the Gray Space, the theme or what the player should feel.
- Nobody praises or blames. The collector reports, and the person across observes.
- Lines are things real students would say, short and plain. If a line would sound good on a poster, cut it.
- The player character speaks once, and only when spoken to.

---

## 3. Interface labels (temporary; see FIRST_SLICE_DESIGN §8)

| Context | 中文 | English |
|---|---|---|
| Place name on entering | 陶舍 | Taoshe |
| Worksheet | 写练习 | Do the exercise |
| Free slot, option 1 | 做第二题 | Do question 2 |
| Free slot, option 2 | 和对面的人喝茶 | Have tea with the person opposite |
| Free slot, option 3 | 去窗边坐着 | Sit by the window |

The three options are listed in this order every time. Nothing beside them shows what they give.

---

## 4. Lines

### 4.1 Evening, free slot: tea

The kettle clicks off. The person across pours two cups.

| Speaker | 中文 | English |
|---|---|---|
| 对面的人 / Person opposite | 第三泡了，没什么味道了。 | Third steeping. There's not much taste left. |
| 学生 / Student | 还行。 | It's fine. |
| 对面的人 / Person opposite | 嗯。 | Mm. |

Then they sit and drink until the bell.

### 4.2 Evening, free slot: window

No words. The window panel opens. Sound only: rain on roof tiles, or a far-off instrument someone is practising. The owner chooses which; both come from a real school evening. Then the bell.

### 4.3 Evening, free slot: question 2

No words. Another encounter of the same type.

### 4.4 Morning: the collector

One line, chosen by what the sheet shows:

| Sheet | 中文 | English |
|---|---|---|
| Both questions answered | 好。 | Okay. |
| Question 2 blank, question 1 answered | 第二题没写？……算了，先收了。 | You didn't do number two? …Fine, I'll take it anyway. |
| Both blank | 两题都空着啊。 | Both blank, huh. |

The collector takes the sheet in every case.

### 4.5 Morning: the person across

One line, chosen by how question 1 was worked. This is the only place anyone acknowledges the working:

| Question 1 on the page | 中文 | English |
|---|---|---|
| One clean line (Join) | 你那题一行就写完了。 | You did that one in a single line. |
| Longer working, one part struck through | 你昨天绕了一圈才算出来。 | You went the long way round last night. |
| Crossed-out guesses, then an answer | 你昨天试了好几个数。 | You tried a lot of numbers last night. |
| Blank (Left or Collapsed) | 你昨晚坐了好久。 | You sat there a long time last night. |

**Self-check.** Each line states a fact the person could have seen across the table. None says the student should have done better.

---

## 5. Worksheet states

The sheet is printed in a plain serif. The working is in the student's handwriting. Images are in `worksheets/`, in Chinese and English versions. They are placeholders to test with: rendered from a free handwriting typeface (Caveat, SIL Open Font License) and a CJK serif, not drawn art.

| State | Comes from | Question 1 shows | File stem |
|---|---|---|---|
| 1 | Released by Join | `2x = 8,  x = 4` | `worksheet_*_1_clean` |
| 2 | Released by Set against and carry | `x = 1 + y` struck through, then `2y = 6, y = 3`, then `x = 7 − 3 = 4` | `worksheet_*_2_longer` |
| 3 | Released by guessing | `x = 5`, `x = 2`, `x = 3` each crossed out, then `x = 4` | `worksheet_*_3_guesses` |
| 4 | Left or Collapsed | Nothing | `worksheet_*_4_blank` |

Question 2 is blank in all four images. If the player does question 2 in the free slot, its working follows the same four patterns with instance 2's numbers (`2x = 12, x = 6`, and so on). That's four more images, made when the free slot is built.

**Open point [Proposal].** Collapsed could show crossed-out guesses with no final answer, instead of a blank. That would be a fifth image. I've kept it to four, as the slice design says.

---

## 6. Traces: prop placement list

| Trigger | Where | What changes | When it is seen |
|---|---|---|---|
| Any return from the Gray Space (the slice's single crack) | The student's paper cup | Moves one hand's width toward the student's elbow, from where it stood before the switch | On return, without comment |
| Free slot: tea | The table beside the student's seat | A second used paper cup stands next to the student's | Next morning |
| Free slot: window | The lattice window nearest the student's seat | One panel left open; morning light and sound come in through it | Next morning |
| Free slot: question 2 | The worksheet | Question 2's working, in the state of the road taken | On return and in the morning |

The design's "unheld object in the Gray Space" (FIRST_SLICE_DESIGN §5) can't appear in this slice, because there's no later Gray Space visit after the free slot. It waits for a second day.

---

## 7. Self-review

- **Lecture check.** No line names a value, a lesson or a feeling. The closest risk is "第三泡了，没什么味道了" being read as a metaphor for studying. It's left in because it's also just true about tea. If the owner hears it as a message, cut it to "第三泡了。"
- **Scope.** 10 written lines (3 for tea, 3 collector variants, 4 morning variants), of which a single playthrough hears at most 5. Plus 4 worksheet images and 4 prop changes. That's within the slice bounds (FIRST_SLICE_DESIGN §9).
- **Choice and feedback.** The morning lines respond to how question 1 was worked, never to the free-slot choice, so the game doesn't comment on what the free hour was for. The choice shows only as a thing left in the room, which follows pillar 5.
- **Unverified.** Whether 课代表 collecting sheets after 晚自习 matches practice at this school. The owner should correct it if not.
