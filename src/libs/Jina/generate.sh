#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://api.jina.ai/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L https://api.jina.ai/openapi.json | jq -S . > openapi.json
autosdk generate openapi.json \
  --namespace Jina \
  --clientClassName JinaClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --methodNamingConvention Summary \
  --base-url https://api.jina.ai/ \
  --security-scheme Http:Header:Bearer

#curl --fail https://segment.jina.ai/openapi.json | jq . > segment-openapi.json
#autosdk generate segment-openapi.json \
#  --namespace Jina \
#  --clientClassName SegmentApi \
#  --targetFramework net10.0 \
#  --output Generated \
#  --exclude-deprecated-operations \
#  --methodNamingConvention Summary \
#  --base-url https://api.jina.ai/ \
#  --security-scheme Http:Header:Bearer
