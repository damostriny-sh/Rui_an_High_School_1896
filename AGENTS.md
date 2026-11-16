# AGENTS.md — how Codex works in this project

Shared project rules for AI assistants. The owner has final approval. Use the mode and scope specified in the current request.

## Roles

- **Owner** (the user): author and final decision-maker on meaning, taste, scope and major direction.
- **Lead** (ChatGPT): coordination, task briefs, technical and scope review, the decision log.
- **Codex**: works on the task assigned to it in `docs/00_project/CURRENT_SPRINT.md`, or on a brief the owner relays. In design phases Codex may propose and challenge; in implementation it carries out approved tasks.
- One implementer per task. Anyone may propose a change, but nobody changes a master document silently.

## Read order

1. `README.md`: folder map
2. `docs/00_project/CURRENT_SPRINT.md`: what is being done now, and by whom
3. `docs/00_project/GAME_MASTER.md`: baseline (the roadmap's GAME_BIBLE)
4. `docs/00_project/DESIGN_DECISIONS.md`: what is decided, what is open (the roadmap's DECISION_LOG)
5. `docs/01_art/ART_DIRECTION.md`: visual grammar (the roadmap's ART_BIBLE)
6. `docs/00_project/TECH_ARCHITECTURE.md`: stack, folders, scenes, contracts
7. Whatever documents the current task names

Use the owner's explicit decisions and their recorded scope, the governing adopted specification for that domain, then proposals and history. Report conflicts and check supersession in DESIGN_DECISIONS.md. File dates and task assignments confer no authority.

## Modes and approvals

| Mode | Responsibility | Default access |
|---|---|---|
| Director | Creative direction and design options | Read-only |
| Architect | Architecture, dependencies and work breakdown | Read-only |
| Builder | Implement an approved task | Write within its approved scope |
| Reviewer | Review quality, evidence and consistency | Read-only |

Major work proceeds through investigation, planning, owner approval, execution, verification and recording. Approval identifies the task, permitted file and content scope, approved decisions, acceptance evidence and rollback. Material changes in gameplay, art direction, architecture or the roadmap require explicit owner approval. Ask for expanded approval if implementation needs a material change outside the agreed scope. Corrections, formatting, links and status updates also require coverage by an approved scope. Keep one implementer per task.

## Rules

1. Work only within the current task. Do not expand scope or add large systems without the owner's confirmation.
2. Never claim code, a scene or a test is done without real evidence (build log, test output, capture from the running scene).
3. Proposals go to `docs/02_design_proposals/`, labelled with source, assumptions and status. A proposal is not a decision until the decision log says so.
4. Keep original references in `reference/` untouched. Mark what is observed in a drawing separately from what is invented for play.
5. Do not create empty documents. Technical structure, contracts and the stack are in `docs/00_project/TECH_ARCHITECTURE.md`; follow it and update it when a work package changes it.
6. Do not redesign the retained HUD in `handoff_hud/` unless a task says so.
7. Record the result and evidence in the current response. Update the sprint row and affected specifications only when those edits are within the approved scope.
8. `docs/03_claude_tasks/CLAUDE_PREPRODUCTION_BRIEF.md` is completed history. Do not execute it again.
