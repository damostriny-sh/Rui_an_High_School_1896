# CLAUDE.md — how Claude works in this project

Read this first in any Claude session on Rui'an High School 1896.

## Roles

- **Owner** (the user): author and final decision-maker on meaning, taste, scope and major direction.
- **Lead** (ChatGPT): coordination, task briefs, technical and scope review, the decision log.
- **Claude**: works on the task assigned to it in `docs/00_project/CURRENT_SPRINT.md`, or on a brief the owner relays. In design phases Claude may propose and challenge; in implementation it carries out approved tasks.
- One implementer per task. Anyone may propose a change, but nobody changes a master document silently.

## Read order

1. `README.md`: folder map
2. `docs/00_project/CURRENT_SPRINT.md`: what is being done now, and by whom
3. `docs/00_project/GAME_MASTER.md`: baseline (the roadmap's GAME_BIBLE)
4. `docs/00_project/DESIGN_DECISIONS.md`: what is decided, what is open (the roadmap's DECISION_LOG)
5. `docs/01_art/ART_DIRECTION.md`: visual grammar (the roadmap's ART_BIBLE)
6. `docs/00_project/TECH_ARCHITECTURE.md`: stack, folders, scenes, contracts
7. Whatever documents the current task names

Priority when documents conflict: the owner's latest decision, then GAME_MASTER, then adopted specifications, then proposals, then history. Report conflicts; never resolve them by file date.

## Rules

1. Work only within the current task. Do not expand scope or add large systems without the owner's confirmation.
2. Never claim code, a scene or a test is done without real evidence (build log, test output, capture from the running scene).
3. Proposals go to `docs/02_design_proposals/`, labelled with source, assumptions and status. A proposal is not a decision until the decision log says so.
4. Keep original references in `reference/` untouched. Mark what is observed in a drawing separately from what is invented for play.
5. Do not create empty documents. Technical structure, contracts and the stack are in `docs/00_project/TECH_ARCHITECTURE.md`; follow it and update it when a work package changes it.
6. Do not redesign the retained HUD in `handoff_hud/` unless a task says so.
7. After a task, update its row in CURRENT_SPRINT.md with the result and evidence, and list the document changes the Lead should review.
8. `docs/03_claude_tasks/CLAUDE_PREPRODUCTION_BRIEF.md` is completed history. Do not execute it again.
