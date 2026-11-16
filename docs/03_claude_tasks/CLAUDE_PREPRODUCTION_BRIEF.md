> **Status: COMPLETED and handed off, 15 Nov 2026** (see DESIGN_DECISIONS.md D015). Kept as the record of the task. Do not execute it again. The current work is in docs/00_project/CURRENT_SPRINT.md.

# Completed task: creative preproduction and a practical production pipeline

You are participating in Rui'an_High_School_1896. The user is the author and final decision-maker. ChatGPT coordinates production, integrates design, writes task briefs, and leads technical review. Your role for THIS phase is creative lead and design contributor, not merely an implementation agent.

Implementation is PAUSED. Your task is to understand the whole game, contribute meaningful creative alternatives, converge on a recommendation, and propose the smallest production pipeline capable of testing it. Do not create a game project, write production code, install tools, redesign the retained HUD, or implement the deferred task brief.

## Read first

All paths are relative to the project root:
1. README.md
2. docs/00_project/GAME_MASTER.md
3. docs/00_project/DESIGN_DECISIONS.md
4. docs/01_art/ART_DIRECTION.md
5. handoff_hud/HUD_handoff.md and its two PNGs
6. reference/Aesthetic/sipping_mountain_front.JPG, then the other accessible illustrations and campus photos
7. docs/02_design_proposals/COMBAT_PROTOTYPE_01.md — an UNAPPROVED candidate to critique, not a prescribed solution
8. docs/00_project/PRODUCTION_ROADMAP.md — lifecycle, responsibilities, and stage gates

Your current deliverables must establish Concept → Core Loop → First Slice Design. A playable prototype precedes the representative vertical slice. Propose a lightweight manual pipeline now; scale automation only after real production evidence. Narrative, integration and playtesting run throughout. A roughly 10–20 minute slice is a provisional target, not a requirement to add content merely to fill time. Earlier examples of stamina, light/heavy attacks, jumping, bosses, mental-state world distortion, specific areas or a hidden-truth plot are NOT fixed requirements. Do not build a second GAME_BIBLE alongside GAME_MASTER; submit proposed decisions in your three deliverables.

Do not treat docs/04_deferred or docs/90_archive as current instructions. If required references are inaccessible, identify exactly which ones; never claim to have seen them. Produce independent analysis from accessible sources and label visual conclusions that remain blocked.

## Boundaries and creative freedom

Preserve the confirmed school setting, two worlds, problem-as-enemy and solution-as-ability relationship, daily schedule, health/sanity consequences, and the user's themes. You may propose how these become an engaging experience: player actions, encounter structure, narrative situation, transitions, recovery choices, environmental staging, and presentation.

The consciousness world's grammar is bodily and spatial: giant hands and limbs intrude, overlap, surround and converge; impossible scale compresses the person; ordinary objects become focal points. Graphite texture alone is insufficient. In sipping_mountain_front the surrounding forms are LIMBS, not canyon walls. Do not infer mountain terrain from its filename. Do not invent canonical meanings for these bodies or furniture. Reality remains bright, saturated, semi-realistic.

You may challenge ChatGPT's candidate. Explain the player-experience problem and a smaller or better alternative; do not silently rewrite constraints. Offer changes to fixed requirements separately as proposals, never as assumed decisions. No automatic open-world expansion, huge character roster, mandatory cloud services, or model training.

## Deliver exactly three compact, substantive documents

Write to docs/02_design_proposals/preproduction/ if you have workspace access; otherwise return clearly separated Markdown drafts for the user to transfer. These are proposals, not approved master documents.

### 1. CREATIVE_PROPOSAL.md

- Restate the confirmed intent and distinguish facts from open questions.
- Write one creative thesis and 3–5 creative pillars. For each pillar, name a visible player experience and a tradeoff it creates.
- Propose TWO meaningfully distinct routes within the same core concept. Compare player action, problem-solving embodiment, rhythm, narrative delivery, visual staging, production cost, and chief risk. Two differently named versions of the same loop are insufficient.
- For each route, describe a short concrete sequence: campus trigger → encounter → return → recovery/choice → narrative consequence.
- Recommend one route with reasons and explicitly say what should NOT be built yet.
- Critique the addition-elimination candidate: does it create embodied understanding or merely turn selecting an answer into an animation? Keep, revise, or replace it with reasons. No need to preserve its numerical tuning.

### 2. FIRST_SLICE_DESIGN.md

- Develop only the recommended route into a small representative slice; do not write the entire game's plot.
- Describe player intention, controls at the action level, information/feedback, success, failure, skip, return, and recovery. Distinguish fiction from systems.
- Explain how the two worlds affect one another and how a meaningful choice supports the existential theme without being only a resource optimization.
- Provide a sipping_mountain_front scene recipe: observed forms versus proposed 3D additions, scale hierarchy, limb/furniture/focal/foreground anchors, navigable space, and camera behavior. The original illustration remains the visual source.
- Identify what the retained campus HUD can support, what is missing, and what should remain temporary. Do not assume its placeholder timetable, NPC or map are canonical.
- Bound the minimum assets, interactions, states and scenes. Use provisional ranges when a duration/cost is uncertain; do not fabricate production estimates.

### 3. PRODUCTION_PIPELINE.md

For gameplay, environment art, narrative, UI, engineering and integration, provide a table of input → work → concrete output → owner/role → dependencies → acceptance evidence → failure/rework destination.

Show two levels: the manual workflow for one encounter and one environment NOW, and only the repetitive steps worth automating AFTER validation. Do not prescribe an elaborate generator, LoRA or asset service before demonstrating need.

Include the art chain: references → visual grammar → scene recipe → composition anchors/blockout → reusable anatomy and ordinary objects → graphite materials/lighting → engine views → review. Include navigation, collision, camera, readability and asset provenance checks; image generation is optional, not a substitute for playable geometry.

Provide the first small set of implementation work packages with dependencies and acceptance criteria, clearly marked NOT STARTED. Identify which can proceed independently, which require a selected creative route, and which require the same owner to avoid scene conflicts. Do not launch agents or services from this brief.

Finish with the top three uncertainties to validate and the smallest experiment for each. Explain how real prototype results could revise the pipeline.

## Self-review and handoff

After drafting, perform an explicit critical review: contradictory rules, excessive scope, unclear player decisions, visual drift, and unsupported tool assumptions. Include findings and adjustments in the documents rather than creating a fourth master document. A separate reviewer/model can later review the same package; do not claim that an independent review already happened.

Do not modify GAME_MASTER.md, ART_DIRECTION.md or DESIGN_DECISIONS.md. ChatGPT will consolidate technical/range review and present the meaningful creative choices to the user. Implementation begins after a route is selected and the deferred tasks are revised to match it. Deliver all three documents in this task; do not stop after merely acknowledging the brief or ask the user to restate already documented requirements.
