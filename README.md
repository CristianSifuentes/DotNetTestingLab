# DotNetTestingLab

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp&logoColor=white)
![xUnit](https://img.shields.io/badge/Testing-xUnit-5C2D91?logo=dotnet&logoColor=white)
![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)
![Module](https://img.shields.io/badge/Current%20Module-0%20--%20Codebase-orange)

Companion repository for the **Unit Testing in .NET and C# with xUnit** course.
Each course module lives on its own branch and builds on top of the previous one — starting from plain, untested code (`0-codebase`) and progressively introducing unit tests, test doubles, mocking, and testing best practices in modules `1` through `5`.

> 📌 This README is a living document. It is updated as each new module branch is published, so the table of contents and roadmap below always reflect the latest state of the course.

---

## Table of Contents

- [About the Project](#about-the-project)
- [Module Roadmap](#module-roadmap)
- [Project Structure](#project-structure)
  - [Module 0 — Codebase](#module-0--codebase)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Clone the Repository](#clone-the-repository)
  - [Switch to a Module Branch](#switch-to-a-module-branch)
  - [Run the Console App](#run-the-console-app)
- [Branch Strategy](#branch-strategy)
- [Contributing](#contributing)
- [License](#license)

---

## About the Project

`DotNetTestingLab` is the hands-on lab used throughout the course. It starts as a small **console application** that performs a series of string manipulation operations (`StringManipulation` project) — deliberately written **without any tests**.

As the course progresses through modules `1` to `5`, this same codebase is incrementally covered with **xUnit** tests, illustrating concepts such as test structure (Arrange/Act/Assert), test doubles, mocking, parameterized tests, code coverage, and CI integration.

## Module Roadmap

| Module | Branch         | Topic                                   | Status        |
|:------:|----------------|------------------------------------------|:-------------:|
| 0      | `0-codebase`   | Base code — string utilities console app, no tests yet | ✅ Done |
| 1      | `1-...`        | _To be announced_                        | 📌 Planned     |
| 2      | `2-...`        | _To be announced_                        | 📌 Planned     |
| 3      | `3-...`        | _To be announced_                        | 📌 Planned     |
| 4      | `4-...`        | _To be announced_                        | 📌 Planned     |
| 5      | `5-...`        | _To be announced_                        | 📌 Planned     |

> ✏️ **Maintainer note:** when a new module branch is published, update its row above (branch name, topic, status) and add a dedicated section for it under [Project Structure](#project-structure), following the same format as [Module 0](#module-0--codebase).

## Project Structure

```text
DotNetTestingLab/
├── LICENSE
├── README.md
├── .gitignore
└── StringManipulation/                # Module 0 — base console app (no tests yet)
    ├── StringManipulation.sln
    ├── StringManipulation.csproj
    ├── Program.cs                      # Console entry point and menu
    ├── StringOperations.cs             # Core logic that will be unit tested
    ├── IFileReaderConnector.cs         # File reader abstraction + implementation
    └── information.txt                 # Sample data file used by the "read file" option
```

### Module 0 — Codebase

The starting point of the course. A single console project, `StringManipulation`, exposing a menu-driven app that performs basic string operations. No test project exists yet at this stage — it is added in later modules.

| File | Responsibility |
|------|-----------------|
| `Program.cs` | Renders the console menu and dispatches the selected option to `StringOperations`. |
| `StringOperations.cs` | Business logic for all string operations — the main subject under test in upcoming modules. |
| `IFileReaderConnector.cs` | Abstraction (`IFileReaderConnector`) and implementation (`FileReaderConnector`) for reading text files, isolated behind an interface to make it mockable in future tests. |
| `information.txt` | Sample file consumed by the "read text file" menu option. |

## Features

The `StringOperations` class exposes the following operations, available from the console menu:

| # | Menu option | Method |
|:-:|-------------|--------|
| 1 | Concatenate two strings | `ConcatenateStrings(str1, str2)` |
| 2 | Reverse a string | `ReverseString(str)` |
| 3 | Get string length | `GetStringLength(str)` |
| 4 | Remove white spaces | `RemoveWhitespace(input)` |
| 5 | Truncate a string | `TruncateString(input, maxLength)` |
| 6 | Check if a word is a palindrome | `IsPalindrome(input)` |
| 7 | Count character occurrences | `CountOccurrences(input, character)` |
| 8 | Pluralize a word | `Pluralize(input)` |
| 9 | Express a quantity in words | `QuantintyInWords(input, quantity)` |
| 10 | Convert from Roman numeral to number | `FromRomanToNumber(input)` |
| 11 | Read a text file | `ReadFile(fileReader, fileName)` |

## Tech Stack

- **.NET 8** / **C# 12**
- [Humanizer](https://github.com/Humanizr/Humanizer) `2.14.1` — pluralization, quantity-to-words, Roman numeral conversion
- `Microsoft.Extensions.Logging` `8.0.0` (+ Console provider) — structured logging
- **xUnit** — introduced starting with Module 1 for unit testing

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Git

### Clone the Repository

```bash
git clone https://github.com/CristianSifuentes/DotNetTestingLab.git
cd DotNetTestingLab
```

### Switch to a Module Branch

Each module is published on its own branch. To follow along with a specific module, check out its branch (the current one is `main`, mirroring module `0-codebase`):

```bash
git checkout 0-codebase
```

### Run the Console App

```bash
cd StringManipulation
dotnet restore
dotnet run
```

Then pick an option from the on-screen menu (1–11) and follow the prompts.

## Branch Strategy

This repository follows a **module-per-branch** strategy:

- `main` — always mirrors the latest published module.
- `0-codebase`, `1-...`, `2-...`, … — one branch per course module, each adding tests and concepts on top of the previous module.

This lets learners diff any two module branches to see exactly what changed (e.g., which tests were added and why).

## Contributing

This repository is course material. Suggestions and corrections are welcome via issues or pull requests — please open an issue first to discuss significant changes.

## License

Distributed under the **Apache License 2.0**. See [LICENSE](LICENSE) for the full text.
