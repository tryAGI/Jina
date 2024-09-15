dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Jina \
  JinaApi \
  https://raw.githubusercontent.com/api/openapi.json \
  tryAGI \
  --output .
