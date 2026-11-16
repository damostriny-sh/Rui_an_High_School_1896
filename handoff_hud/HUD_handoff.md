# HUD handoff: single-scene campus HUD design

> Scope: retained static campus HUD under D002. Existing appearance and prototype notes are kept here. Live bindings, resource definitions and state changes are governed by the adopted slice rules and technical contracts.

From Claude to the production lead (ChatGPT), relayed by the project owner. 15 Nov 2026.

Everything below was read from the design source on 15 Nov 2026 (artifact version `1794659732-af94`). It is a design mock-up. Nothing in it is implemented in a game, and no element is connected to game state.

Labels used: **[seen]** = read directly from the design source. **[note]** = written in the owner-approved design notes but not drawn or animated. **[proposal]** = my suggestion, not an existing decision.

---

## A. Existing design and visual references

**What it is.** A Claude Design canvas titled "Rui'an 1896 — three art style directions".
Link: https://claude.ai/artifact/PmPqT9mmFmRQdN1bu7G2ot (private to the owner's account; ChatGPT cannot open it, so use the PNGs in this folder).

**Boards on the canvas [seen]**

| Board | Size | Status |
|---|---|---|
| B · At rest, interaction available | 1920×1080 | **The retained design**, state 1 |
| B · Holding right click | 1920×1080 | **The retained design**, state 2 |
| Font options for style B | 1920×1640 | Type specimen; option 3 (Spectral / Noto Serif SC) was chosen by the owner |
| A · Printed paper | 1920×1080 | Rejected alternative, kept for comparison |
| C · Instrument | 1920×1080 | Rejected alternative, kept for comparison |

**Scene depicted [seen].** One outdoor daytime campus view, third-person, camera behind where the player would stand: a main building with a dome, a pond, a plaza with a sculpture, trees. The place label reads "Solar-lunar pond". The backdrop is a flat vector placeholder drawn only to give the HUD something to sit on. It is not game art and not a style target. No player character is drawn.

**Gameplay context.** Walking on campus in school reality. No combat, consciousness-space, dialogue, menu or exam HUD exists in the retained design.

**Screenshots in this folder**
- `B_at_rest_interaction_available.png`
- `B_holding_right_click.png`

These are 1920×1080 re-renders I made from the design source with the same typeface (Spectral). They are not exports from the canvas tool, and I checked them by eye against the source values, not against the live canvas pixel by pixel.

---

## B. Element and style specification

Canvas 1920×1080. Every element is anchored to a corner with the same margins: **48 px from the left/right edge, 44 px from the top/bottom edge** [seen]. Nothing overlaps; there is one HUD layer above the scene.

### B1. Elements

| # | Element | Anchor | What it shows | Spec [seen] |
|---|---|---|---|---|
| 1 | Upper bar (yellow) | Top-left | A fill level, 72% in the mock-up. No label, no number | Track 240×12, corner 2; track fill near-black `rgba(20,18,16,0.5)`; 1 px light ring `rgba(244,238,226,0.35)`; fill `#F5C83F` |
| 2 | Lower bar (blue) | Top-left, 12 px below bar 1 | A fill level, 30% in the mock-up, drawn in its "low" look | Same track; fill `#7DB9F0`; ring replaced by 1.5 px `#FF8A7A` (the low-value warning) |
| 3 | Place name | Top-right, right-aligned | "Solar-lunar pond" | Spectral 600, 28 px, letter-spacing 0.03em, `#F4EEE2`, soft dark text shadow |
| 4 | Line under place name | Top-right, 2 px below | "Monthly examination in 4 days" | Spectral 500, 18 px, `#E4DCCB`, same shadow |
| 5 | Time label | Bottom-left, centred above the map, 10 px gap | Sun icon + "15:40 · Period 6" | Pill: padding 5×16, corner 14, dark glass `rgba(20,18,16,0.62)` with 14 px background blur; Spectral 600, 18 px, tabular figures, letter-spacing 0.04em; icon 20 px line drawing, stroke 1.8, 8 px before the text |
| 6 | Small map | Bottom-left | Line drawing of nearby outlines, a player arrow, one yellow dot, one blue dot | Circle, 220 px; same dark glass and blur; 2 px light ring `rgba(244,238,226,0.55)`; outlines 1.5 px `#F4EEE2` at 75% / 50% opacity; dots radius 5; arrow `#F4EEE2`, pointing up, slightly above centre |
| 7 | Mouse icon (state 1 only) | Bottom-right | A mouse outline with the right button filled yellow | 26×34, stroke 1.6 `#F4EEE2`, body fill `rgba(20,18,16,0.5)`, right button `#F5C83F`, drop shadow |
| 8 | Key prompt list (state 2 only) | Bottom-right, replaces element 7 | Four rows, label then key cap: "Talk to the librarian" E, "Bag" Tab, "Map" M, "Pause" Esc | Rows 10 px apart; label Spectral 20 px, letter-spacing 0.02em, 12 px before the cap. Cap: height 30, min width 34, side padding 8, corner 2, Spectral 600 15 px. Normal row: label `#F4EEE2` weight 500; cap fill `rgba(20,18,16,0.5)`, 1 px border `rgba(244,238,226,0.85)`. Active row (first): label `#F5C83F` weight 600; cap fill and border `#F5C83F`, text `#1A1612` |

The two boards are identical except for the bottom-right corner (element 7 versus element 8).

### B2. Meaning of the elements, from the design notes [note]

- Bar 1 is HP (the body resource), bar 2 is RA (rationality; the brief's "sanity"). The design itself carries no label, so this assignment exists only in the notes.
- Map dots: yellow = a marked place, blue = a marked person.
- State 1's mouse icon means "hold right click; an interaction is available" (this is the icon's accessibility text in the source). State 2 is what holding shows.

### B3. Style tokens [seen]

| Token | Value |
|---|---|
| Text | `#F4EEE2` |
| Secondary text | `#E4DCCB` |
| Theme yellow | `#F5C83F` |
| Theme blue | `#7DB9F0` |
| Low-value warning | `#FF8A7A` |
| Text on yellow | `#1A1612` |
| Dark glass | `rgba(20,18,16,0.62)` + 14 px blur (map, time label); `rgba(20,18,16,0.5)` (bar tracks, key caps, mouse body) |
| Text shadow | `0 1px 2px rgba(0,0,0,0.7)` plus `0 0 14px rgba(0,0,0,0.45)` |
| Typeface, English | Spectral, weights 500 and 600 (Google Fonts, SIL Open Font License as far as I know; verify before shipping) |
| Typeface, Chinese | Noto Serif SC chosen on the specimen board. **No Chinese version of the HUD is drawn** |
| Type sizes in use | 28, 20, 18, 15 px at 1080p |
| Corner radii in use | 2 (bars, caps), 14 (time pill), full circle (map) |

### B4. Icons and assets

- Three icons exist, all as inline vector drawings inside the design: sun, mouse, player arrow. There are no separate icon files. I can extract them as SVG on request.
- Of the time-of-day icons, only the sun is drawn [seen]. Sunrise, sunset and moon are proposed in the notes, not drawn.
- The map contents are a hand-placed placeholder drawing, not generated from any level.

### B5. Transitions

**None exist in the design [seen].** Both boards are static.
Timings in the notes [note], never animated or tested: bars and place name fade in over about 0.5 s, hold 3 s after the last change, fade out over about 1 s. The switch between state 1 and state 2 has no specified timing.

### B6. What is static, placeholder, or not designed

| Kind | Items |
|---|---|
| Static visuals | Everything. Two still frames |
| Placeholder values | 72% and 30% fills; "Solar-lunar pond"; "Monthly examination in 4 days"; "15:40 · Period 6"; "Talk to the librarian"; the key letters E / Tab / M / Esc; the map drawing and dot positions; the whole backdrop. None of these is an approved location list, character, schedule, key binding or exam rule |
| Preview-only interaction | One: the warning colour (`#FF8A7A`) is exposed as an editable colour property in the design tool. There is no hover, click, hold or playback behaviour |
| Composite frame | The boards show the bars, the low warning, the place name and the prompts all at once to display the parts together. The notes say bars and place name are hidden by default, so this frame is not a typical moment of play |

---

## C. Future data/action requirements and missing states

All of this section is **[proposal]**. No API exists. The HUD would read state and send action requests; the rules layer owns health, sanity, time, results and saving.

### C1. Data each element would read

| Element | Needs |
|---|---|
| Bars 1 and 2 | Current and maximum value for each resource; a "low" flag or threshold per resource; a change event to trigger showing |
| Place name | Current area's display name (per language); an "entered new area" event |
| Line under place name | A short notice string and the event that raises it. What kinds of notice exist is undecided |
| Time label | Clock time; current period name or number; time-of-day category for the icon |
| Small map | Player position and facing; nearby map geometry; a list of marked points with a type (place / person). Whether the map rotates with the camera is undecided |
| Mouse icon | Whether an interaction is currently available; the active input device |
| Key prompt list | The list of currently valid actions, each with a display label and its bound key from the input system (so remapping and controller glyphs work) |

### C2. Action requests the HUD would send

The design shows prompts for four actions: **interact**, **open bag**, **open map**, **pause**, plus the **hold-to-reveal** gesture itself (purely a HUD display state; it changes nothing in the game). The HUD would send requests by action name; it would not resolve them.

### C3. States not designed

1. The fully quiet state: bars and place name hidden, no interaction available (how the mouse icon looks without the yellow button is not drawn).
2. Bars: full, empty, increasing versus decreasing, and the yellow bar's low state (only the blue bar's low look is drawn).
3. Fade in/out for bars and place name; the transition between state 1 and state 2.
4. Time icons other than the sun; day or week change.
5. Map: anything other than this one placeholder; indoor areas; edge-of-map markers; a north mark.
6. Chinese version of every element.
7. Controller prompts; remapped keys; long action labels and longer place names.
8. Other resolutions and aspect ratios, and scaling rules. Only 1920×1080 exists.
9. Everything outside this scene: combat/consciousness-space HUD, dialogue, menus, pause, notices beyond the one line, damage or loss feedback.

---

## D. Available exports and unresolved questions

### D1. Available

| Item | Where |
|---|---|
| Live design | The artifact link in section A (owner's account only) |
| Two PNG re-renders, 1920×1080 | This folder |
| This specification | This file |
| Image or PDF export of any board | The owner can download these from the design canvas. I have not produced canvas exports myself |

Not available: engine assets, sprite sheets, separate icon files, a font package, any Unity or other project files, any animation.

### D2. Observations (no change made)

1. **Contrast over bright scenes.** Elements 3 and 4 are off-white text with only a shadow, and in the mock-up they sit on a pale sky. In the render the 18 px line is hard to read. The design brief for the real world is "bright, saturated", so this will recur.
2. **The mouse icon is small** (26×34 at 1080p) and is the only always-on signal that an interaction exists.
3. **Colour alone separates the two bars**, and yellow against blue fill on a dark track with no label depends on the player learning it. The low state adds a thin 1.5 px edge that is easy to miss.
4. **Background blur** on the map and time label costs a blur pass in an engine. A flat translucent fill looks nearly identical on this backdrop.
5. **Thin 1 to 2 px strokes** (map lines, rings, cap borders) need a decision on how they scale at 1440p and 4K.

### D3. Unresolved questions for the owner and production lead

1. The written design notes and the canvas disagree. The notes describe always-visible key prompts (interact, bag, check); the canvas shows a mouse icon at rest and a hold-right-click list of E / Tab / M / Esc with no "check" action. The canvas is newer. Which is authoritative?
2. Is the bar assignment (yellow = health, blue = rationality/sanity) confirmed? It was my call inside the owner's choice of the two colours.
3. Is the line under the place name part of the retained design, or just sample text? It presumes an exam countdown.
4. Does the time label keep "Period N"? It presumes a numbered timetable.
5. Are the show/hide rules for bars and place name (hidden by default, shown on change) retained as intent, or to be redefined with the gameplay systems?
6. Should the same layout be the basis for the consciousness-space HUD later, or is that a separate brief?

---

I have changed nothing in the design and created no new screens. I will wait for the next task brief, relayed by the owner.
