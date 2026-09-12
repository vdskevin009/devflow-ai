# Architecture

## Decision

Use standalone Blazor WebAssembly and .NET 11 for C# domain logic with zero-server hosting. This favors low operating cost and an easy portfolio deployment. Server-dependent features are deferred explicitly rather than embedding credentials in the client.

## Components

IRequirementsGenerator separates planning from the UI; TemplateRequirementsGenerator is the free implementation. IIssuePublisher defines the future publishing boundary. A server-side AI adapter can be added after cost approval; a GitHub App adapter should use scoped OAuth and review before writes. Keep API keys and tokens out of WebAssembly.

Browser UI → C# domain → browser storage. Downloaded backups and issue links are user-initiated data exits. Domain code has no network dependencies.

## Privacy and persistence

No AI model is called in this MVP. Generated acceptance criteria are starting points and require refinement. GitHub draft links send title/body in the URL; submission is manual. Long bodies are truncated with an explicit notice; use downloaded Markdown for full content.

Local storage is best-effort, subject to quotas and browser deletion. Errors surface in the UI. App-specific storage keys and cache prefixes avoid accidental collisions, but all apps on one github.io origin can access the same origin storage. Future sensitive data requires an authenticated backend and server-side authorization.

## Testing

The executable harness tests domain boundaries and known scenarios. Release publish verifies Razor compilation, trimming and static assets. Browser smoke checks cover the primary workflow. Tests and publish run before the deploy job; pull requests cannot deploy.

## Deployment

GitHub Actions builds a versioned Pages artifact. A separate job uses pages:write and id-token:write only after build success. Main deploys through the github-pages environment. Pull requests get read-only permissions. Dependency versions are pinned; review updates to .NET RC versions before merging.

## Roadmap

1. Authenticated GitHub App integration
2. AI requirement refinement
3. PR reviews
4. test generation
5. release-note drafts.

No paid hosting or external AI calls without Kevin's approval.
