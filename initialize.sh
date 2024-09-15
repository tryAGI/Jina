dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  SolutionName \
  SomeApi \
  https://raw.githubusercontent.com/api/openapi.json \
  CompanyName \
  --output .
