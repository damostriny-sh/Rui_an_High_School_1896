# SCENE_TAOSHE_ROOM — recipe for the reality side of the first slice

Status: **proposal.** Author: Claude, 15 Nov 2026. Fills the gap that `FIRST_SLICE_DESIGN.md` left: §7 covers the Gray Space room only. It also covers part of the roadmap's W2 "Art Bible" item for the reality side.
Source: `reference/Campus/inside_the_taoshe_building.JPG`, one photo, daytime, one viewpoint. Confirmed as the slice's reality room (D012).
Labels: **[Observed]** in the photo; **[Estimate]** read from the photo, unmeasured; **[Proposal]** mine.

---

## 1. Observed in the photo

**Room.** Walls and ceiling of vertical wooden planks, warm honey colour, with dark posts and beams. Grey stone tile floor. **[Observed]**

**Back wall.** Four tall vertical calligraphy scrolls in two pairs: black brush characters on orange-red paper, with cream mounts. They are the most saturated thing in the room. **[Observed]**

**Light.** One woven, birdcage-shaped pendant lamp over the near end of the table, glowing warm yellow. Daylight comes from the windows. **[Observed]**

**Right wall.** A continuous row of wooden lattice windows in a geometric frame pattern, with green foliage and a grey building outside. Lower panels are solid wood. **[Observed]**

**Table.** One very long live-edge slab: dark red-brown, highly glossy, irregular edges, running from the near foreground to the back wall. Down its middle runs a strip of **white pebbles** holding several small grey stones and a potted green plant. **[Observed]**

**Seating.** Dark wooden chairs with high yoke backs line both long sides. One bright yellow plastic stool stands among them. **[Observed]**

**On the table.** A stainless-steel electric kettle; a glass jar; many white paper cups, some holding tea, some stacked, printed with the school's emblem; plastic water bottles; a crumpled plastic bag. **[Observed]**

**Character of the place.** Traditional and formal (wood, calligraphy, lattice), used casually (paper cups, plastic bottles, a plastic stool). This mix is what makes it a real school room rather than a museum.

## 2. Correspondences with `sipping_mountain_front` [Proposal]

The owner confirmed the drawing is this room (D012). These are possible readings of the match for the owner to accept or reject. None is a fixed meaning.

| In the drawing | In the photo | Use |
|---|---|---|
| The pale area in the middle of the dark table | The white pebble strip down the middle of the dark slab | **The strongest link.** In the Gray Space the student stands on the pale area; in reality the pebble strip is in the same place in the table. The switch can grow the strip into the arena |
| Small rounded forms on the table's rim | The small grey stones in the pebble strip | Possible. Shape and position differ |
| Two small cups on the pale area | Paper cups on the table | Direct. The cup is already the slice's anchor object |
| Three pedestals standing off the table | The chairs or the stool | Weak. Kept only as a note |
| Rounded-triangular table on one foot | A long rectangular slab on legs | **They differ.** The Gray Space table is the drawing's, not a copy of the real one |

## 3. Scale [Estimate]

Read from the photo against the chairs (a seat is roughly 45 cm high). Measure the real room before modelling it to final.

| Thing | Estimate |
|---|---|
| Table length | 4 to 6 m |
| Table width | 0.9 to 1.3 m |
| Pebble strip width | about a quarter to a third of the table's width |
| Ceiling height | 3.5 to 4.5 m |
| Chairs per long side | 6 to 8 |

## 4. The slice's layout [Proposal]

```
         back wall: four scrolls
   ┌─────────────────────────────────┐
   │  chairs  ┌───────────────┐ chairs│
   │          │ table +pebble │       │ lattice
   │ OPPOSITE→│      strip    │←STUDENT│ windows
   │          │   kettle      │  (W)  │  ← nearest window = "window" option
   │          └───────────────┘       │
   └──────────── entrance ────────────┘
             (camera start)
```

- **Student's seat:** the window side, about mid-table, facing across. The nearest window is the "window" option.
- **Person opposite:** directly across, on the plain-wall side (left in the photo).
- **Kettle:** between them, slightly to one side, so that "have tea" happens at the table.
- **Worksheet:** flat in front of the student. The student's paper cup stands to its upper right; this is the cup that moves on return.
- **Walkable floor:** the aisles on both sides of the table and the entrance end. The student can stand up, walk to the window and sit on a chair turned to face it. (The photo shows no window seat; a turned chair avoids inventing one.) No other room is reachable in the slice.

## 5. Camera [Proposal]

- **Walking:** behind the student, as everywhere on campus (the owner's standing rule).
- **Seated:** a fixed view over the student's shoulder, looking across the table at the person opposite and the scrolls, with the worksheet in the lower foreground.
- **The switch:** the camera stays seated. Colour drains from the frame edges inward, the pebble strip whitens and widens into the arena, and the camera rises into the drawing's view (FIRST_SLICE_DESIGN §3). This lets the first frame of the Gray Space be read as the same table.

## 6. Lighting and colour, evening [Proposal]

- **Key light:** the pendant lamp, warm. A few dimmer wall or ceiling lights fill the far end, so the scrolls stay readable.
- **Windows:** deep blue outside. The lattice reads as dark pattern against it.
- **Saturation order, as checks:** red scrolls > green plant > wood > everything else. The red scrolls must be the most saturated element, so that the drain to grey is felt most there.
- **Morning:** daylight from the windows as in the photo. If the window option was chosen, one panel is open and the light from it is the brightest thing in the room.

This follows the baseline for reality (bright, saturated, semi-realistic; ART_DIRECTION) applied to an interior. Proposed as the first reality rules for the Art Bible once tested: **real materials, everyday clutter left in, one dominant saturated element per room, and warm practical lights at night.**

## 7. Content that needs the owner's decision

- **The calligraphy.** The scrolls in the photo are real works with real texts and signatures. The game should use **original text and calligraphy** in the same format, not copies. Owner to supply, or to approve new text.
- **The school emblem on the cups.** It's recognisably the real school's. Using it is the owner's call.
- **People.** The baseline rule stands: real place, composite people. Nobody in the room is based on a real person.

## 8. Minimum assets for the slice

| Asset | Count | Note |
|---|---|---|
| Room shell: plank walls, ceiling, beams, stone floor | 1 | Plank texture reused |
| Lattice window | 1 module, repeated | One panel can open |
| Long slab table with pebble strip | 1 | Pebble strip a separate mesh, to animate in the switch |
| Small stones, potted plant | 3–4 stones, 1 plant | |
| Yoke-back chair | 1 model, repeated | |
| Plastic stool | 1 | Keep it. It's the room's everyday note |
| Pendant lamp | 1 | Emissive |
| Scrolls | 4 | Original text, see §7 |
| Kettle, glass jar | 1 each | |
| Paper cup | 1 model, 3 states | Empty, with tea, stacked |
| Water bottle, plastic bag | a few | Clutter |
| Worksheet | 1 mesh, 4 textures | See SLICE_NARRATIVE §5 |

## 9. Acceptance checks

- A capture of the seated view beside the photo: the owner recognises the room.
- The red scrolls are the most saturated element in the frame.
- The pebble strip reads as a pale band down a dark table in both reality and the first Gray Space frame.
- The cup's move on return is noticeable to a player who looks, and not flagged by anything else.
- Untextured blockout first, as in the Gray Space chain (PRODUCTION_PIPELINE §3).
