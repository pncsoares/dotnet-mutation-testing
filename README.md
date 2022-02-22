# Dotnet Mutation Tests

This repository aims to demonstrate how the tests that we create, sometimes, means nothing, even if we cover all of our source code with tests.

[How mutation tests improved our tests 📄](/MutationTesting/MutationTesting.Tests/README.md)

# Technologies

- [.Net](https://dotnet.microsoft.com/en-us/download)
- [.Net CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [xUnit](https://xunit.net)
- [Stryker Mutator](https://stryker-mutator.io/docs/stryker-net/Introduction)

# Setup

## Clone repository

Create and go to the directory where you want to place the repository

```bash
  cd my-directory
```

Clone the project

```bash
  git clone https://github.com/pncsoares/dotnet-mutation-tests.git
```

Go to the project directory

```bash
  cd dotnet-mutation-tests
```

## Build

```bash
  dotnet build
```

## Execute tests

```bash
  dotnet test
```

# License

MIT