# Stryker Mutator

Stryker.NET offers you mutation testing for your .NET Core and .NET Framework projects.

It allows you to test your tests by temporarily inserting bugs. For more information, consult the mutations [here](https://stryker-mutator.io/docs/stryker-net/mutations).

You can execute the stryker in CI and CD pipelines. To do that, read [this article](https://stryker-mutator.io/docs/stryker-net/stryker-in-pipeline).

## Example using this calculator project

- [Stryker results using weak tests 📄](BadAndWeakTests/README.md)
- [Stryker results using stronger tests 📄](StrongerTests/README.md)

# Setup 

## Install stryker

Stryker can be installed globally for your whole system or locally for a specific project.

### Install globally

```bash
dotnet tool install -g dotnet-stryker
```

### Install in project

Create a file called dotnet-tools.json in your project folder if this is your first local tool.

```bash
dotnet new tool-manifest
```

Then install stryker without the -g flag by executing the following command in the project folder

```bash
dotnet tool install dotnet-stryker
```

Check the dotnet-tools.json file into source control

Now the rest of your team can install or update stryker with the following command:

```bash
dotnet tool restore
```

### Prepare

Make sure the working directory for your console is set to the unit test project dir.

### Execute

For most projects no configuration is needed. Simply run stryker and it will find your source project to mutate.

```bash
dotnet stryker
```

### Analise the results

After you run `dotnet stryker`, the results will be written in the console and you just need to open the generated `.html` and analise the results.