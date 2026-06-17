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
- [Course Overview](#course-overview)
  - [What is a .NET unit testing course?](#what-is-a-net-unit-testing-course)
  - [How do you implement unit tests in a string manipulation project?](#how-do-you-implement-unit-tests-in-a-string-manipulation-project)
  - [What are the benefits of refactoring with unit tests?](#what-are-the-benefits-of-refactoring-with-unit-tests)
  - [Why is this course essential for your career?](#why-is-this-course-essential-for-your-career)
- [Course Prerequisites](#course-prerequisites)
  - [What prior knowledge do you need for this course?](#what-prior-knowledge-do-you-need-for-this-course)
  - [What .NET version is used, and does it work with newer versions?](#what-net-version-is-used-and-does-it-work-with-newer-versions)
  - [Which IDE should you use to follow the course?](#which-ide-should-you-use-to-follow-the-course)
    - [What if you use macOS or Linux?](#what-if-you-use-macos-or-linux)
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

## Course Overview

### What is a .NET unit testing course?

In the exciting world of software development, unit tests play a vital role in ensuring the quality and stability of code. This course takes you into the world of unit testing in .NET, teaching you to build small pieces of code that exercise the logic of your applications, helping you keep a high standard of quality across your projects. You will learn to manipulate strings and to use Visual Studio to run automated tests, making sure your code works correctly before it ever reaches production.

### How do you implement unit tests in a string manipulation project?

#### Understanding the project

Throughout the course we work on a project that involves several string operations — a fundamental building block in many applications (see [Features](#features)). These hands-on exercises not only help you understand how tests work, but also serve as practice tasks so you can apply what you've learned yourself. This practical approach is key to building a deep, applicable understanding.

#### Writing tests in Visual Studio

Visual Studio is our main tool for creating and running tests. In a `StringOperationsTest` class, you'll find several tests implemented for the `StringOperations` class (see [Module 0 — Codebase](#module-0--codebase)). These tests run automatically through **Test Explorer**, a powerful Visual Studio feature that discovers and executes tests, clearly showing whether the code passes or fails.

#### Example unit test in C#

Here's a snippet showing how a function becomes a unit test:

```csharp
[Fact]
public void ConcatenateStringsTest()
{
    var result = new StringOperations().ConcatenateStrings("Hello", "Plexi");
    Assert.Equal("Hello Plexi", result);
}
```

This simple snippet shows how the `[Fact]` attribute (xUnit's equivalent of NUnit/MSTest's `[Test]`) marks a method as a unit test, and how assertion methods are used to verify that the result meets expectations.

### What are the benefits of refactoring with unit tests?

#### Refactoring safely

Refactoring is a systematic process aimed at improving code quality without changing its behavior. In the course, you'll see how `ConcatenateStrings` is refactored to use **string interpolation**, going from:

```csharp
public string ConcatenateStrings(string str1, string str2)
{
    return str1 + " " + str2;
}
```

to:

```csharp
public string ConcatenateStrings(string str1, string str2)
{
    return $"{str1} {str2}";
}
```

Modifying and improving code is much safer with unit tests in place, since they confirm that your changes haven't broken existing functionality.

#### Catching and fixing bugs

During a refactor it's easy to introduce a mistake that leads to a failing test — for instance, forgetting the space between the two values. Situations like this demonstrate the real value of unit tests: they stop bugs from propagating into production. Once the issue is identified, it only takes a small fix (restoring the missing space) and a re-run of the tests to confirm that everything passes again and the functionality is intact.

### Why is this course essential for your career?

This course gives you the tools to approach any software project with confidence. You'll learn how to design unit tests that strengthen the quality of your applications, and you'll pick up essential refactoring skills — a crucial part of every developer's day-to-day work. With all of this in your toolkit, you'll be ready to take on the challenges of modern software development. Keep going, and never stop learning!

## Course Prerequisites

Before diving into unit testing with C# and .NET, it's worth confirming you have everything in place to follow the course smoothly. Here's the prior knowledge, framework versions, and recommended tooling so you can move forward with confidence from the very first class.

### What prior knowledge do you need for this course?

The starting point is clear: you need a working knowledge of the language and the framework before writing your first test.

- C# as a programming language.
- .NET as a development framework.
- Solid foundations in object-oriented programming (OOP) in C#.

If you feel any of these pillars are missing, don't worry — there are dedicated courses for each of these topics you can take beforehand to arrive prepared.

> **Do I need to know object-oriented programming to take this course?** Yes. OOP in C# is the foundation unit testing is built on, so you should be comfortable with concepts such as classes, objects, inheritance, and encapsulation.

### What .NET version is used, and does it work with newer versions?

The course was originally recorded on **.NET 7**, the latest release available at the time of recording. Here's the important part: .NET is **backward compatible**, so everything you learn also applies to newer versions such as .NET 8, .NET 9, or .NET 10.

This means you can follow the course even if your own environment runs a newer version — the concepts, test syntax, and logic you apply remain valid. In fact, this repository itself has already been upgraded to **.NET 8** (see [Tech Stack](#tech-stack)) without changing any of the testing concepts described here.

> **What does it mean for .NET to be backward compatible?** It means code written for an older version keeps working on newer versions, so your learning doesn't become obsolete when you switch versions.

### Which IDE should you use to follow the course?

The official IDE for the course is **Visual Studio 2022**, the latest version at the time of recording. It's the recommended tool because it natively integrates everything you need to create, run, and debug unit tests in .NET.

#### What if you use macOS or Linux?

If your operating system doesn't support Visual Studio, the alternative is **Visual Studio Code** together with the **.NET CLI**. With this combination you run terminal commands that do exactly what you would otherwise do from the Visual Studio graphical interface (see [Run the Console App](#run-the-console-app) for the CLI commands used in this repo).

- **On Windows:** Visual Studio 2022, with its full IDE experience.
- **On macOS or Linux:** Visual Studio Code plus the .NET CLI to run commands from the terminal.

The workflow changes slightly, but the result is the same: you can create projects, add packages, and run tests without losing any functionality.

> **Does Visual Studio Code replace Visual Studio?** For this course, yes — as long as you use the .NET CLI. Terminal commands do the same job as the IDE's buttons; only the way you interact with the project changes.

With these prerequisites covered, you're ready to move on to the next key question of the course: what unit tests really are, and why they matter so much for your code.

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
