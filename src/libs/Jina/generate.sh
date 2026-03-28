#!/usr/bin/env bash
set -euo pipefail
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L https://api.jina.ai/openapi.json | jq -S . > openapi.json
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
