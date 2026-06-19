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
- [Unit Testing and TDD Fundamentals](#unit-testing-and-tdd-fundamentals)
  - [What is TDD, and why does it change how you code?](#what-is-tdd-and-why-does-it-change-how-you-code)
  - [What are unit tests, and what characteristics do they have?](#what-are-unit-tests-and-what-characteristics-do-they-have)
  - [How do unit tests relate to TDD?](#how-do-unit-tests-relate-to-tdd)
  - [Why do unit tests matter in your project?](#why-do-unit-tests-matter-in-your-project)
  - [What advantages do they have over other automated tests?](#what-advantages-do-they-have-over-other-automated-tests)
- [Unit Testing Libraries in .NET: MSTest, NUnit, and xUnit](#unit-testing-libraries-in-net-mstest-nunit-and-xunit)
  - [What is MSTest, and what are its advantages?](#what-is-mstest-and-what-are-its-advantages)
  - [What are the characteristics of NUnit?](#what-are-the-characteristics-of-nunit)
  - [What makes xUnit different from the rest?](#what-makes-xunit-different-from-the-rest)
  - [How are tests implemented in xUnit?](#how-are-tests-implemented-in-xunit)
- [Creating Your First Unit Test with xUnit](#creating-your-first-unit-test-with-xunit)
  - [Why separate the test project from the main project?](#why-separate-the-test-project-from-the-main-project)
  - [How do you set this up from the .NET CLI (Visual Studio Code)?](#how-do-you-set-this-up-from-the-net-cli-visual-studio-code)
  - [How do you name testing projects and classes?](#how-do-you-name-testing-projects-and-classes)
  - [How do you write a unit test step by step?](#how-do-you-write-a-unit-test-step-by-step)
  - [How do you run tests from Test Explorer?](#how-do-you-run-tests-from-test-explorer)
- [Best Practices and Assert Types in xUnit](#best-practices-and-assert-types-in-xunit)
  - [What is the AAA (Arrange-Act-Assert) structure?](#what-is-the-aaa-arrange-act-assert-structure)
  - [What are the FIRST principles of testing?](#what-are-the-first-principles-of-testing)
  - [How do you apply AAA to the ConcatenateStrings test?](#how-do-you-apply-aaa-to-the-concatenatestrings-test)
  - [How do you cover more scenarios with multiple asserts?](#how-do-you-cover-more-scenarios-with-multiple-asserts)
  - [How do you test functions that return true or false?](#how-do-you-test-functions-that-return-true-or-false)
  - [What happens if you force a test to fail?](#what-happens-if-you-force-a-test-to-fail)
  - [How do you run xUnit tests from the terminal?](#how-do-you-run-xunit-tests-from-the-terminal)
  - [Practice challenge: testing RemoveWhitespace](#practice-challenge-testing-removewhitespace)
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

## Unit Testing and TDD Fundamentals

Unit tests are pieces of code that test other pieces of code, and together with the Test-Driven Development (TDD) methodology, they let you guarantee a project's quality from the very first line you write. Whether you work with .NET or any other language, understanding this concept opens the door to development that is more organized, automatable, and reliable.

### What is TDD, and why does it change how you code?

Before writing your first unit test, you need to understand the framework that supports them. **TDD** stands for **Test-Driven Development**, a workflow methodology where you write the tests first and implement the code afterward.

It sounds strange, but it makes sense: thanks to user stories, you already know what your code should do, what calculations it should perform, what information it should return, and in which scenarios. With that information you build tests that, at first, will fail because the implementation doesn't exist yet. Your goal at that point is simply to make sure the tests themselves are well structured.

Then you write the real code and do whatever is needed to make each test pass. Whenever new logic appears — a different user story or a scenario you hadn't considered — you enter a constant refactor cycle: add tests, fail again, implement again, pass again. And that's the cycle you stay in for good.

> **What is TDD in programming?** It's a methodology where you write the tests first, based on the requirements, and then implement the code until those tests pass.

### What are unit tests, and what characteristics do they have?

This is where the piece that supports the whole methodology comes in. **Unit tests** are tests performed on small units of code: a property, a function, or a method.

To work properly within a TDD flow, they need three characteristics that make them powerful:

- **Automatable** — you can run them at any time without manual intervention, which lets you verify the code constantly.
- **Reusable** — the same test can validate different scenarios.
- **Independent** — they don't depend on databases, external services like AWS or Azure, or other parts of the system.

This independence is one of the trickier challenges. If your code connects to an external service, you need to simulate that connection so you can focus on what you actually want to test: the business logic, the math operations, the calculations, and the conditions in your code.

### How do unit tests relate to TDD?

Unit tests are the vehicle that makes TDD possible. Without them, you couldn't run fast, repeatable validations against your code. With them, every change you make passes through an automatic filter that tells you whether you broke something or whether the new logic affects behavior that was already established.

> **What are unit tests for?** They verify, in an automated way, that each unit of your code (a function, method, or property) does exactly what's expected — even after changes or refactors.

### Why do unit tests matter in your project?

The real value of unit tests is the speed at which they show you the health of your code. You make a change, run the tests, and within seconds you know whether you broke part of the business logic or whether everything still works as expected.

There's another point worth highlighting: unit tests are written by the developers themselves, not by external QA or automation teams. That makes them much closer to the real code and much easier to weave into the daily development workflow.

### What advantages do they have over other automated tests?

Compared to automated tests that use frameworks like Selenium or Cypress, unit tests are much easier to implement. Each type of test focuses on a different aspect of the software, but the strength of unit tests lies precisely in their simplicity and in how fast they give you feedback.

To write them you'll always rely on a library — there are hundreds of options across the development world, and every language has its own. For .NET, there are a few concrete alternatives worth knowing before you write your first test (this repo uses **xUnit**; see [Tech Stack](#tech-stack)).

> 📚 Suggested resource from this lesson: *Unit Testing Succinctly* (free ebook).

## Unit Testing Libraries in .NET: MSTest, NUnit, and xUnit

Before diving into unit testing in .NET, it's worth understanding the different libraries available for writing and running tests. There are several solid options and, although each has its own particularities, they all offer great capabilities. This course settles on one in particular, but it's worth knowing the alternatives.

### What is MSTest, and what are its advantages?

**MSTest** — also known as Microsoft Test — is a library with strong backing from Microsoft, and one of the first to appear in .NET Framework. Its integration with Visual Studio stands out, which makes the unit testing process easier for teams already working with Microsoft technologies. That said, it can feel heavier in scenarios where you need simpler tests, or where the code is already well structured and decoupled.

### What are the characteristics of NUnit?

**NUnit** takes its inspiration from JUnit, the well-known Java library, replicating much of its functionality. It's open source and enjoys massive community support. Some of its advantages include:

- Simplicity of use — tests can be written with very little code.
- Extensive documentation, tutorials, and guides, thanks to its active community.
- Its resemblance to JUnit gives developers with Java experience a faster learning curve.

### What makes xUnit different from the rest?

**xUnit** is probably the most innovative of the three, born out of community effort and former members of Microsoft's own teams. It's also open source and is strongly preferred in modern .NET Core projects and in microservices and cloud-based architectures. This library stands out for:

- Simplifying the process of creating unit tests.
- Its use of the `[Fact]` attribute, which turns an ordinary method into a unit test just by adding that attribute.
- Efficient execution and verification of business logic through assertions.

### How are tests implemented in xUnit?

Implementing unit tests in xUnit is remarkably intuitive: you use the `[Fact]` attribute to mark a method as a test, and inside it you use assertions to validate the expected behavior of your code. This ease of use is the main reason **xUnit** was chosen as the testing library for this course (see [Tech Stack](#tech-stack) and the example under [Example unit test in C#](#example-unit-test-in-c)).

> 🔗 **Resources from this lesson:** [NUnit.org](https://nunit.org/) · [xUnit.net](https://xunit.net/) · *Unit testing C# with MSTest and .NET* (Microsoft Learn)

## Creating Your First Unit Test with xUnit

Writing your first unit test is simpler than it looks once you understand the project structure, the naming conventions, and how the `[Fact]` attribute works. This is the lesson where the test project for `StringManipulation` gets set up, the first test gets written, and it gets executed from Visual Studio to confirm the code does what it should.

### Why separate the test project from the main project?

A good practice in .NET development is to keep tests in their own project and reference the project under test from there. Mixing business logic with tests creates unnecessary coupling and complicates deployment.

In Visual Studio, within the same solution, you add a new project with **Add > New Project**. Filtering by the word "Test" surfaces the official templates: **MSTest**, **NUnit**, and **xUnit**. These templates ship with all the required libraries preinstalled, which saves you the manual setup.

> **Can I use a regular Class Library instead of the Test template?** Yes. You can create a Class Library and manually add the xUnit NuGet packages — the template only automates that step.

### How do you set this up from the .NET CLI (Visual Studio Code)?

If you're following along in **Visual Studio Code** instead of Visual Studio (see [What if you use macOS or Linux?](#what-if-you-use-macos-or-linux)), the [.NET CLI](https://learn.microsoft.com/dotnet/core/tools/) does exactly what the IDE's menus do, as terminal commands run from the repository root:

```bash
# 1. Create a solution file alongside the library project's folder
dotnet new sln --name UnitTestingNetCSharp

# 2. Create the xUnit test project
dotnet new xunit -o StringManipulationTest

# 3. Add both projects to the solution
dotnet sln add StringManipulation/StringManipulation.csproj
dotnet sln add StringManipulationTest/StringManipulationTest.csproj

# 4. Reference the library project from the test project
dotnet add StringManipulationTest/StringManipulationTest.csproj reference StringManipulation/StringManipulation.csproj
```

`dotnet new xunit` is the CLI equivalent of picking the **xUnit Test Project** template in Visual Studio — it scaffolds the project with the xUnit and `Microsoft.NET.Test.Sdk` packages already wired up. The `dotnet add ... reference` command is what makes `StringOperations` visible to the test project, the same project reference you'd add by hand through Visual Studio's Solution Explorer.

> 📌 This run named the test project `StringManipulationTest` (singular, no dot). The naming convention covered next recommends the plural `StringManipulation.Tests` — both work functionally; the convention is a team preference, not a compiler requirement.

Once the reference is in place, `dotnet test` from the solution folder runs the whole suite — the CLI's equivalent of Test Explorer's "Run All".

### How do you name testing projects and classes?

.NET has a clear community standard for naming test projects and classes. Following it means any developer can understand your structure at a glance.

- The **test project** takes the name of the project under test plus the plural word **Tests** — e.g., `StringManipulation.Tests` for the `StringManipulation` project in this repo.
- The **test class** takes the name of the class under test plus the singular word **Test** — e.g., `StringOperationsTest` for the `StringOperations` class (see [Module 0 — Codebase](#module-0--codebase)).
- The class **must be `public`**. Visual Studio scaffolds it as `internal` by default, which silently keeps the runner from executing the tests.

After creating the project from the **xUnit Test Project** template and picking a target framework (this repo targets **.NET 8**; see [Tech Stack](#tech-stack)), you add a project reference to `StringManipulation`. Without that reference you can't import `StringOperations` or call its methods.

### How do you write a unit test step by step?

Every unit test follows the same three beats: **Arrange** the object, **Act** on it, and **Assert** the result. In xUnit, turning a method into a test is as simple as adding the `[Fact]` attribute above it:

```csharp
using Xunit;

public class StringOperationsTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.ConcatenateStrings("Hello", "World");

        // Assert
        Assert.Equal("Hello World", result);
    }
}
```

Breaking down what happens there:

1. An instance of `StringOperations` is created with `new`.
2. `ConcatenateStrings` is called with two strings: `"Hello"` and `"World"`.
3. The result is compared against the expected value with `Assert.Equal`.

`Assert` is the xUnit class that performs the actual check. `Assert.Equal` takes the **expected** value first and the **actual** value second — if they match, the test passes.

> **What does the `[Fact]` attribute do?** It turns a regular method into a unit test that the runner can discover and execute. Without it, xUnit ignores the method entirely.

> **Why must the test class be `public`?** Because xUnit's runner can only access public classes. An `internal` class won't run its tests, even if its methods carry `[Fact]`.

### How do you run tests from Test Explorer?

Visual Studio ships with **Test Explorer**, a tool that automatically discovers every test in the solution. If it's not visible, enable it from **View > Test Explorer**.

From there you can:

- Run every test in the project with a single click.
- Run an individual test by selecting it and pressing **Run**.
- See the result in green when it passes, or red when it fails.

A green result means the method's behavior matches what you expected. Changing the expected value — say, adding an extra space — turns the test red. That's the core value of unit testing: it catches the moment a code change breaks previously working logic, without you having to review everything by hand.

Once this structure is in place, adding tests for the rest of `StringOperations`'s methods (see [Features](#features)) is just a matter of repeating Arrange-Act-Assert and letting Test Explorer do the rest.

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `1-primeraprueba`.

## Best Practices and Assert Types in xUnit

Writing clear unit tests isn't only about the tool — it's about how you organize the code inside each test. This lesson formalizes the **AAA** structure and introduces several `Assert` methods to cover more scenarios in the `StringManipulation` project.

### What is the AAA (Arrange-Act-Assert) structure?

The AAA structure organizes the code inside each test into three blocks:

- **Arrange** — set up the initial data, variables, and objects the test needs.
- **Act** — execute the function under test and store the result in a variable.
- **Assert** — check that the result matches what's expected.

Since each test should exercise a single function, one variable is enough to hold the result before checking it.

> **Why is it called "triple A"?** Because all three phases start with A — arrange, act, and assert — the logical order any well-written test follows.

### What are the FIRST principles of testing?

**FIRST** is a set of rules that matters once a test project grows large enough to need structure, so it doesn't turn into unmaintainable spaghetti code. They aren't covered in depth in this course since they're considered foundational knowledge, but both AAA and FIRST come up often in technical interviews, so they're worth knowing: **F**ast, **I**ndependent, **R**epeatable, **S**elf-validating, **T**horough.

### How do you apply AAA to the `ConcatenateStrings` test?

Mapping the AAA blocks onto the test from [How do you write a unit test step by step?](#how-do-you-write-a-unit-test-step-by-step):

- **Arrange** — instantiate `StringOperations`, the class that holds the function under test.
- **Act** — call `ConcatenateStrings` and store the result in a `result` variable.
- **Assert** — use `Assert.Equal` to compare `result` against the expected value.

### How do you cover more scenarios with multiple asserts?

A good practice is checking several possible outcomes within the same test. If you only validate equality and the test fails, you don't know whether the problem is a `null` value, an empty string, or simply a different string.

xUnit ships with many assertion methods — typing `Assert.` in Visual Studio shows every option through autocomplete. The most useful ones to start with:

- `Assert.NotNull(result)` — checks the value isn't `null`.
- `Assert.NotEmpty(result)` — checks it isn't an empty string.
- `Assert.Equal("Hello, World", result)` — checks exact equality.

Combining these three lines covers three different scenarios. If the test fails, you know exactly where the problem is without guessing.

### How do you test functions that return `true` or `false`?

When a function returns a boolean, you need to test both outcomes — when it returns `true` and when it returns `false`. This is one of the most important testing practices.

Take `IsPalindrome` as an example, applying AAA:

```csharp
[Fact]
public void IsPalindrome_True()
{
    // Arrange
    StringOperations strOperations = new StringOperations();

    // Act
    var result = strOperations.IsPalindrome("ama");

    // Assert
    Assert.True(result);
}
```

`"ama"` reads the same forwards and backwards, so the function should return `true`. For the opposite scenario, duplicate the test, pass `"hello"` instead, and assert with `Assert.False(result)`.

> **How do you name tests with multiple scenarios?** Use the function's name, an underscore, and the scenario — `IsPalindrome_True` and `IsPalindrome_False`. That way, anyone reading the test list knows immediately which case each one validates.

### What happens if you force a test to fail?

You can swap `Assert.True` for `Assert.False`, or tweak `IsPalindrome`'s logic, just to confirm your tests actually catch errors. If a test breaks when it's supposed to, it's doing its job.

### How do you run xUnit tests from the terminal?

Besides Visual Studio's Test Explorer, you can run your tests from the terminal with a single command. Open a terminal (**View > Terminal**) and run:

```bash
dotnet test
```

This command walks the whole solution, discovers every test project, and runs all of its tests together — useful when you want to wire test execution into CI/CD pipelines or automate validation outside the IDE (see [Run the Console App](#run-the-console-app) for the other `dotnet` CLI commands used in this repo).

### Practice challenge: testing `RemoveWhitespace`

The challenge is to write tests for `RemoveWhitespace` (see [Features](#features)), which strips whitespace from a string. Apply everything covered in this section:

- The AAA structure in every test.
- Combined asserts — `NotNull`, `NotEmpty`, and `Equal`.
- Descriptive names with scenarios separated by an underscore.

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
