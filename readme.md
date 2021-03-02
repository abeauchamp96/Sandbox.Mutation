# Lunch and share on Mutation!

## Mutate .Net Framework

### Steps

#### Install stryker

* dotnet new tool-manifest
* dotnet tool install dotnet-stryker
* cd Mutation.Services.Tests/
* dotnet stryker -s "..\Mutation.sln"
