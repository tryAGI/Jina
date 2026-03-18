# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Jina AI](https://jina.ai/) platform (embeddings, reranking, classification, search), auto-generated from the Jina OpenAPI specification using [AutoSDK](https://github.com/tryAGI/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Jina.slnx

# Build for release (also produces NuGet package)
dotnet build Jina.slnx -c Release

# Run integration tests (requires JINA_API_KEY env var)
dotnet test src/tests/IntegrationTests/Jina.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Jina && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** — do not manually edit files in `src/libs/Jina/Generated/`.

1. `src/libs/Jina/openapi.json` — the Jina OpenAPI spec (fetched from `https://api.jina.ai/openapi.json`, formatted with `jq`)
3. `src/libs/Jina/generate.sh` — orchestrates: download spec → fix spec → run AutoSDK CLI → output to `Generated/`
4. CI auto-updates the spec every 3 hours and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Jina/` | Main SDK library (`JinaClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Jina API |

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# 13 preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + FluentAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
