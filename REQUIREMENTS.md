# DevFlow AI — Canonical Requirements

> **Source of truth for product requirements.** Read this file before changing the product. Update it whenever a requirement, scope boundary, implementation status, or decision changes.

## Baseline

- **Repository:** `vdskevin009/devflow-ai`
- **Default branch:** `main`
- **Baseline verified:** 2026-09-26
- **Code reference:** `f281cf79235641a2bdacbbf5b0c6b831be931e8c`

## Requirement lifecycle

Statuses: `Proposed`, `Accepted`, `In progress`, `Implemented`, `Verified`, `Deferred`, `Superseded`, `Rejected`.

Rules:
1. Add new user requirements here before or with implementation.
2. Do not treat generated suggestions as authoritative business requirements until a human accepts them.
3. Mark `Implemented` only when code exists; mark `Verified` after checks/acceptance.
4. Preserve superseded requirements and decisions for traceability.
5. Never imply an external GitHub action happened when only a draft/link was produced.

## Product requirements

| ID | Requirement | Status | Implementation notes |
|---|---|---|---|
| DF-001 | DevFlow AI is a feature-request workbench that turns an idea into a structured, editable implementation brief. | Verified | Current MVP scope. |
| DF-002 | Requirement generation must remain deterministic in the current MVP and must not imply that an AI model was called when none was. | Verified | No AI model call in baseline. |
| DF-003 | Generated acceptance criteria/checklists are starting points and must remain editable before use. | Verified | Editable Markdown workflow. |
| DF-004 | Support feature-specific checklists for common concerns such as CSV, auth, search and notifications. | Implemented | Current MVP. |
| DF-005 | Users must be able to save drafts locally and download the complete brief as Markdown. | Implemented | Current MVP. |
| DF-006 | GitHub issue creation must remain explicit: a draft link may be generated, but submission is manual unless a future authenticated integration is implemented. | Verified | Current GitHub draft-link flow. |
| DF-007 | If a GitHub draft URL must truncate a long body, the UI must make that limitation explicit and preserve full content through Markdown download. | Verified | Current limitation/mitigation. |

## Delivery / architecture

| ID | Requirement | Status | Implementation notes |
|---|---|---|---|
| DF-TECH-001 | Active stack is Blazor WebAssembly with domain logic in `src/Core` and UI in `src/Web`. | Verified | Current repository layout. |
| DF-TECH-002 | CI must build, run the executable domain test harness and publish before deployment. | Verified | Current delivery contract. |
| DF-TECH-003 | GitHub Pages is the deployment target and the current MVP requires no server, database or paid AI API. | Verified | Current architecture. |
| DF-TECH-004 | .NET 11 prerelease SDK/package versions must be changed together and tested. | Accepted | Stability constraint. |
| DF-TECH-005 | Browser-local drafts must not be treated as secure storage for sensitive data. | Verified | Current limitation. |

## Roadmap requirements

| ID | Requirement | Status | Implementation notes |
|---|---|---|---|
| DF-RM-001 | Consider authenticated GitHub App integration for explicit issue/PR workflows. | Proposed | Roadmap. |
| DF-RM-002 | Consider AI-assisted requirement refinement without losing human review/acceptance. | Proposed | Roadmap. |
| DF-RM-003 | Consider PR review, test generation and release-note drafting workflows. | Proposed | Roadmap. |

## Open questions / Needs confirmation

- Any future automatic GitHub write action must define user confirmation, permissions, failure handling and auditability before implementation.

## Decision log

| Date | Decision | Result |
|---|---|---|
| 2026-09-26 | Establish `REQUIREMENTS.md` as the canonical requirement source. | Accepted |
| 2026-09-26 | Baseline against `f281cf79235641a2bdacbbf5b0c6b831be931e8c`. | Accepted |

## Maintenance checklist

Before implementation: read this file, identify affected IDs, add new requirements, and record conflicts.

After implementation: update statuses/notes, run build/tests, update the code reference after merge, and keep README/docs aligned.
