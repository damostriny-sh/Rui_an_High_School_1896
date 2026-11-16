# Rui'an High School 1896

当前阶段：前期收尾（路线图 Pre-production，W1–W2）。前期创意设计已交付，用户已选定 Route A；当前任务见冲刺文件。Unity 空工程已通过 Windows 构建。玩法原型按冲刺验收门槛推进。

## 阅读入口

1. [当前冲刺](docs/00_project/CURRENT_SPRINT.md)：这两周做什么、谁负责、怎样验收。
2. [项目主文档](docs/00_project/GAME_MASTER.md)：有效设定、职责、阶段与决策权限。
3. [决策记录](docs/00_project/DESIGN_DECISIONS.md)：哪些已确认，哪些暂缓或开放。
4. [艺术方向](docs/01_art/ART_DIRECTION.md)：意识空间视觉语法。
5. [制作路线图](docs/00_project/PRODUCTION_ROADMAP.md)：从前期到发布的阶段、分工与验收门槛。
6. [前期设计提案](docs/02_design_proposals/preproduction/)：创意提案、首个切片设计、生产流程。
7. [共同 AI 协作规则](AGENTS.md)与 [Claude 入口](CLAUDE.md)。
8. [风格语法](docs/01_art/STYLE_GENOME.md)、[WP1 桌测](docs/04_playtest/WP1_TWO_TRAYS_TABLETOP.md)和 [HUD 交接](handoff_hud/HUD_handoff.md)。

## 路线图文件名对应（D017）

| 路线图中的文件 | 本项目中的文件 | 状态 |
|---|---|---|
| GAME_BIBLE.md | docs/00_project/GAME_MASTER.md | 现行 |
| PRODUCTION_ROADMAP.md | docs/00_project/PRODUCTION_ROADMAP.md | 现行，部分内容按 D016 调整 |
| ART_BIBLE.md | docs/01_art/ART_DIRECTION.md | 现行 |
| TECH_ARCHITECTURE.md | docs/00_project/TECH_ARCHITECTURE.md | v0，空工程已构建，架构提案见正文 |
| CURRENT_SPRINT.md | docs/00_project/CURRENT_SPRINT.md | Sprint 1 |
| DECISION_LOG.md | docs/00_project/DESIGN_DECISIONS.md | 现行 |
| CLAUDE.md | CLAUDE.md | 现行 |

路线图建议文档与工程同在一个 Git 仓库。做法：本文件夹即仓库根目录，Unity 工程建在其中的 Game/ 子文件夹（TECH_ARCHITECTURE.md §3），文档位置不变。

## 分类

| 位置 | 用途与状态 |
|---|---|
| CLAUDE.md | Claude 工作规程 |
| .gitignore、.gitattributes | Git 与 LFS 设置，按 Game/ 布局准备 |
| Game/ | Unity 空工程与构建配置 |
| docs/00_project/ | 主文档、路线图、冲刺与决策记录，当前权威入口 |
| docs/01_art/ | 当前艺术方向 |
| docs/02_design_proposals/preproduction/ | 前期设计提案；Route A 已选定，其余细节待批准 |
| docs/03_claude_tasks/ | Claude 任务书；前期任务书已完成，仅作记录 |
| docs/04_playtest/ | 试玩与测试材料及记录 |
| handoff_hud/ | 已完成的校园 HUD 设计交接；尚未实现 |
| reference/Aesthetic/ | 用户原创插画，保留原文件 |
| reference/Campus/ | 校园照片，保留原文件 |
| reference_contact.jpg | 已有参考图总览 |

## 已作废

COMBAT_PROTOTYPE_01.md、docs/04_deferred/、docs/90_archive/ 已作废（D019）。其他文档中对它们的提及仅为历史记录。

新的产出按实际需要逐步建立目录，不预先生成空白文档。
