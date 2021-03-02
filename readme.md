# Lunch and share on Mutation!

## Mutate typescript with angular

### Steps

#### Code coverage

ng test --no-watch --code-coverage

#### Install stryker

npm i stryker-cli
stryker init
npm i --save-dev @stryker-mutator/typescript-checker
"checkers": ["typescript"]
"tsconfigFile": "tsconfig.json"
"!src/**/main.ts"
"!src/**/app-routing.module.ts"
stryker run