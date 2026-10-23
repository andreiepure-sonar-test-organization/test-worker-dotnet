# .NET worker fixture

A small .NET 10 console application (no NuGet dependencies) for exercising the Autoscan **.NET worker**.

```sh
dotnet build
dotnet run
```

`Inventory.cs` has two intentional issues, so a successful automatic analysis should report them:

- an unused private field
- an empty `catch` block
