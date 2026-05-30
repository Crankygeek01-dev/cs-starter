# cs-starter

[![CI](https://github.com/Crankygeek01-dev/cs-starter/actions/workflows/ci.yml/badge.svg)](https://github.com/Crankygeek01-dev/cs-starter/actions/workflows/ci.yml)

A minimal C# starter: .NET 10 solution with a console app and xUnit tests.

## Requirements

- [.NET SDK 10](https://dotnet.microsoft.com/) (`dotnet --version`)

## Layout

```
cs-starter.sln
src/CsStarter/            # console app
  Program.cs
  MathUtils.cs            # example module
tests/CsStarter.Tests/    # xUnit tests
  MathUtilsTests.cs
```

## Commands

| Command                                   | What it does            |
| ----------------------------------------- | ----------------------- |
| `dotnet run --project src/CsStarter`      | Run the app             |
| `dotnet test`                             | Run the tests           |
| `dotnet build`                            | Build the solution      |
| `dotnet format`                           | Format the code         |
