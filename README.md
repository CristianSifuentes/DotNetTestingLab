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
- [Testing with StartsWith, Contains, and Throws](#testing-with-startswith-contains-and-throws)
  - [How do you test that a string starts with a given word?](#how-do-you-test-that-a-string-starts-with-a-given-word)
  - [When should you use Contains instead of Equal?](#when-should-you-use-contains-instead-of-equal)
  - [How do you test that a function throws an exception?](#how-do-you-test-that-a-function-throws-an-exception)
  - [What happens if the function doesn't throw the expected exception?](#what-happens-if-the-function-doesnt-throw-the-expected-exception)
  - [Can you still apply AAA in exception tests?](#can-you-still-apply-aaa-in-exception-tests)
  - [Which exceptions are worth covering with tests?](#which-exceptions-are-worth-covering-with-tests)
  - [Practice challenge: testing TruncateString](#practice-challenge-testing-truncatestring)
- [The Fact Attribute in Depth](#the-fact-attribute-in-depth)
  - [What does the Fact attribute represent in xUnit?](#what-does-the-fact-attribute-represent-in-xunit)
  - [What are the core characteristics of Fact?](#what-are-the-core-characteristics-of-fact)
  - [Fact vs. Theory: which one should you use?](#fact-vs-theory-which-one-should-you-use)
- [Parameterized Tests with Theory and InlineData](#parameterized-tests-with-theory-and-inlinedata)
  - [Why parameterize unit tests in xUnit?](#why-parameterize-unit-tests-in-xunit)
  - [How do you write a Theory and InlineData test step by step?](#how-do-you-write-a-theory-and-inlinedata-test-step-by-step)
  - [What happens if one scenario fails?](#what-happens-if-one-scenario-fails)
  - [When should you use Theory in your tests?](#when-should-you-use-theory-in-your-tests)
  - [Practice challenge: parameterizing IsPalindrome](#practice-challenge-parameterizing-ispalindrome)
- [Module Roadmap](#module-roadmap)
- [Project Structure](#project-structure)
  - [Module 0 — Codebase](#module-0--codebase)
  - [Module 1 — First Test](#module-1--first-test)
  - [Module 2 — Types Assert](#module-2--types-assert)
  - [Module 3 — Types Assert 2](#module-3--types-assert-2)
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

## Testing with StartsWith, Contains, and Throws

Unit tests don't always need to check that a result is exactly equal to some text. Sometimes it's enough to confirm it starts with a given word, contains a fragment, or that a function throws an exception when it receives an invalid parameter. This lesson covers `StartsWith`, `Contains`, and `Throws` to cover those real-world scenarios.

### How do you test that a string starts with a given word?

`Assert.StartsWith` checks that a string begins with a specific substring. It's ideal when the full result can vary but the beginning must stay constant.

Take `QuantintyInWords`, which receives a word and a number and returns something like `"ten cats"` when you pass `"cat"` and `10`. Instead of comparing the whole result, you validate just the start:

```csharp
[Fact]
public void QuantintyInWords()
{
    var strOperations = new StringOperations();
    var result = strOperations.QuantintyInWords("cat", 10);
    Assert.StartsWith("ten", result);
    Assert.Contains("cat", result);
}
```

> 📌 `QuantintyInWords` relies on [Humanizer](https://github.com/Humanizr/Humanizer) (see [Tech Stack](#tech-stack)) to spell out the number, and Humanizer's output is culture-dependent. If your environment's locale isn't English, the result may come back localized (e.g., `"diez"` instead of `"ten"`) — adjust the expected prefix to match your environment without losing the validation logic.

> **What does `StartsWith` do in xUnit?** It checks that a string begins with a specific substring — useful when the rest of the result can vary but the start must stay constant.

### When should you use Contains instead of Equal?

Use `Assert.Contains` when you only need to confirm a word appears in the result, regardless of its position or whether it's pluralized. That gives you flexibility when the exact format can change.

In the example above, the function can return a pluralized `"cats"`. Validating with `Equal` risks failing the test over a minor formatting detail; `Contains` only confirms the word `"cat"` is present.

The practical lesson: be deliberate about what you check. You don't always need exact equality — sometimes verifying that a fragment is present is enough, and it makes your tests more resilient to small changes.

### How do you test that a function throws an exception?

When a function deliberately throws an exception for invalid parameters, that logic also needs test coverage. xUnit provides `Assert.Throws<T>` to validate that code throws the expected exception type.

`GetStringLength` (see [Features](#features)) throws an `ArgumentNullException` when it receives `null`. To test it, wrap the call in a lambda expression so it can be used as a delegate:

```csharp
[Fact]
public void GetStringLength_Exception()
{
    var strOperations = new StringOperations();
    Assert.Throws<ArgumentNullException>(() => strOperations.GetStringLength(null));
}
```

> **Why do I need a lambda with `Assert.Throws`?** Because `Throws` requires a delegate, not a direct call. The lambda wraps the call so xUnit can execute it and capture the exception inside the assert.

### What happens if the function doesn't throw the expected exception?

If you pass a valid value instead of `null`, the test fails with a clear message: an exception was expected and none was thrown. That confirms the test is doing its job of catching unexpected behavior.

### Can you still apply AAA in exception tests?

These tests skip one of the three A's, since there's no **act** step that stores a result to check afterward — the execution and the verification happen together inside `Throws`. That's expected for this scenario and is perfectly valid (see [What is the AAA (Arrange-Act-Assert) structure?](#what-is-the-aaa-arrange-act-assert-structure)).

### Which exceptions are worth covering with tests?

Not every exception deserves a unit test — only the ones that are part of the code's controlled logic, signals the function throws on purpose to flag misuse. Examples worth covering in this project:

- `GetStringLength` throws `ArgumentNullException` when it receives `null`.
- `TruncateString` throws `ArgumentOutOfRangeException` when `maxLength` is less than or equal to zero.
- Any range check or required-parameter validation your own logic defines.

### Practice challenge: testing `TruncateString`

Write two tests for `TruncateString` (see [Features](#features)): one validating the successful case, and another confirming it throws `ArgumentOutOfRangeException` when `maxLength` is invalid. Together they cover both paths through the code.

> 🔗 **Quick recap:** `StartsWith` validates the beginning of a string, `Contains` validates that a fragment is present, and `Throws<T>` validates that a specific exception is thrown — three tools for covering far more realistic scenarios than plain equality.

## The Fact Attribute in Depth

Every test written so far in this README — `ConcatenateStringsTest`, `IsPalindrome_True`, `GetStringLength_Exception`, and the rest — shares the same building block: the `[Fact]` attribute. This section pulls together everything that attribute is responsible for, so it's documented in one place instead of scattered across each lesson.

### What does the Fact attribute represent in xUnit?

In xUnit, the `[Fact]` attribute declares a **parameterless** unit test that checks an invariant — a scenario that should always be true, regardless of context. It represents one fixed, concrete case: no input parameters, no external data configuration, just a single hardcoded expectation.

```csharp
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_TwoPlusTwo_ReturnsFour()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(2, 2);

        // Assert
        Assert.Equal(4, result);
    }
}
```

> 📌 This generic `CalculatorTests` example follows the exact same AAA shape already used by this repo's own tests — compare it with `ConcatenateStringsTest` in [How do you write a unit test step by step?](#how-do-you-write-a-unit-test-step-by-step).

### What are the core characteristics of Fact?

- **No parameters** — the test method must contain zero arguments.
- **Single test case** — it produces exactly one test outcome in the test runner, no matter how many assertions live inside it.
- **Isolated lifecycles** — xUnit instantiates a brand-new instance of the test class for every individual `[Fact]` it executes, so one test can never leak mutable state into the next.
- **Optional named parameters** — you can pass arguments directly to the attribute itself, such as `[Fact(Skip = "Reason")]` to bypass a test without deleting it, or `[Fact(DisplayName = "Custom Name")]` to change how it's labeled in the test runner's output.

```csharp
[Fact(Skip = "Pending fix for negative operands")]
public void Add_NegativeNumbers_ReturnsSum()
{
    // ...
}

[Fact(DisplayName = "Adding 2 + 2 should return 4")]
public void Add_TwoPlusTwo_ReturnsFour()
{
    // ...
}
```

> **Why does xUnit create a new test class instance per Fact?** To guarantee isolation — each test starts from a clean, predictable state instead of inheriting whatever a previous test left behind. When you genuinely need to share expensive setup across tests, xUnit offers class fixtures (`IClassFixture<T>`) rather than relying on shared instance state.

### Fact vs. Theory: which one should you use?

| | `[Fact]` | `[Theory]` |
|---|---|---|
| Use case | Standalone, concrete scenario with hardcoded values | Parameterized testing — the same logic exercised with different inputs |
| Parameters | None | Accepts arguments, fed by attributes like `[InlineData]` |
| Test outcomes | Exactly one | One per data row supplied |

Every `[Fact]` test in this repo so far fits the same mold: a single hardcoded scenario per test, as in `IsPalindrome_True` and `IsPalindrome_False` (see [How do you test functions that return true or false?](#how-do-you-test-functions-that-return-true-or-false)). `[Theory]` and `[InlineData]` become useful once you want to collapse near-duplicate `[Fact]` tests like those two into a single parameterized test — a pattern planned for a future module (see [Module Roadmap](#module-roadmap)).

> 🔗 **Further reading:** [xUnit.net documentation](https://xunit.net/) · *Difference between Fact and Theory?* (Stack Overflow) · *Xunit test context to run only once per class* (Stack Overflow) · *Skipping a whole test class in xUnit.net* (Stack Overflow)

## Parameterized Tests with Theory and InlineData

Reusing unit tests in xUnit lets you validate multiple scenarios with a single structure, using the `[Theory]` and `[InlineData]` attributes. This lesson builds directly on [The Fact Attribute in Depth](#the-fact-attribute-in-depth): it's what to reach for once writing one `[Fact]` per scenario starts feeling repetitive.

### Why parameterize unit tests in xUnit?

When you write a test with `[Fact]`, you're validating a single, fixed scenario (see [What are the core characteristics of Fact?](#what-are-the-core-characteristics-of-fact)). If you want to cover several cases, you end up copying the same structure over and over — and that's where the real problem shows up: duplicated code, costly maintenance, and tests that get harder to read.

`[Theory]` solves this by turning a test method into a parameterizable template. Each data set you supply runs as an independent execution, so the test runner reports exactly which scenario passed and which one didn't.

> **What does the Theory attribute do in xUnit?** It turns a test method into a parameterizable template. Unlike `[Fact]`, it lets you run the same test with different input values and expected results.

### How do you write a Theory and InlineData test step by step?

This example uses `FromRomanToNumber` (see [Features](#features)), which takes a Roman numeral string and returns its `int` equivalent. A parameterized test has three parts:

1. The `[Theory]` attribute, replacing `[Fact]`.
2. One or more `[InlineData]` attributes, each carrying the input value(s) and the expected result.
3. Parameters on the test method that match the `InlineData` values in order and type.

```csharp
[Theory]
[InlineData("V", 5)]
[InlineData("III", 3)]
[InlineData("X", 10)]
public void FromRomanToNumber(string romanNumber, int expected)
{
    var result = strOperations.FromRomanToNumber(romanNumber);
    Assert.Equal(expected, result);
}
```

Each `[InlineData]` line represents a different scenario: the first value fills `romanNumber`, the second fills `expected`. The runner executes this test three times, once per combination.

### What happens if one scenario fails?

xUnit visually separates each case in Test Explorer. If you add an incorrect data row on purpose — say, `[InlineData("P", -1)]` — that single scenario shows up as failed while the others keep passing. That granularity is one of the biggest advantages over a plain `[Fact]`, where a single bad assertion fails the whole test without telling you which input caused it.

> **What's the difference between Fact and Theory?** `[Fact]` defines a parameterless test that validates a single case. `[Theory]` defines a parameterized test that runs multiple times, once for each data set supplied via `[InlineData]` (see [Fact vs. Theory: which one should you use?](#fact-vs-theory-which-one-should-you-use)).

### When should you use Theory in your tests?

Reach for `[Theory]` whenever a function has uniform behavior but multiple valid inputs. A few practical cases from this project:

- Validating conversions, like Roman numerals to integers (`FromRomanToNumber`).
- Testing text-transformation functions, like `QuantintyInWords`.
- Unifying boolean tests — for example, checking whether a word is a palindrome with both `true` and `false` cases in a single method, instead of keeping `IsPalindrome_True` and `IsPalindrome_False` as two separate `[Fact]` tests (see [How do you test functions that return true or false?](#how-do-you-test-functions-that-return-true-or-false)).

That last example is especially useful: instead of maintaining two separate methods — one for valid palindromes and one for invalid ones — you combine them into a single parameterized test and cut the testing code in half.

> **What is InlineData in xUnit?** An attribute that supplies data directly in the source code for a `[Theory]` test. Each `InlineData` represents an independent execution of the test, with its own input values and expected output.

Reuse through parameters is part of what makes a unit test well designed. A test that scales to new scenarios without rewriting its logic is a maintainable test.

### Practice challenge: parameterizing IsPalindrome

Rewrite `IsPalindrome_True` and `IsPalindrome_False` (see [How do you test functions that return true or false?](#how-do-you-test-functions-that-return-true-or-false)) as a single `[Theory]` test, using `[InlineData]` rows for both the palindrome and non-palindrome cases — a direct way to confirm how `[Theory]` collapses near-duplicate `[Fact]` tests into one.

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `4-theoryInlineData`.

## Module Roadmap

| Module | Branch         | Topic                                   | Status        |
|:------:|----------------|------------------------------------------|:-------------:|
| 0      | `0-codebase`   | Base code — string utilities console app, no tests yet | ✅ Done |
| 1      | `1-firsttest`  | First xUnit test project — `StringManipulation.Tests` scaffolded and wired via `ProjectReference` | ✅ Done |
| 2      | `2-types-assert` | AAA convention + multi-assert tests — `Assert.NotNull`/`NotEmpty`/`Equal` and the `IsPalindrome_True`/`_False` boolean pair | ✅ Done |
| 3      | `3-types-assert2` | `StartsWith`/`Contains`/`Throws` — `QuantintyInWords` and `GetStringLength_Exception` | ✅ Done |
| 4      | `4-...`        | _To be announced_                        | 📌 Planned     |
| 5      | `5-...`        | _To be announced_                        | 📌 Planned     |

> ✏️ **Maintainer note:** when a new module branch is published, update its row above (branch name, topic, status) and add a dedicated section for it under [Project Structure](#project-structure), following the same format as [Module 0](#module-0--codebase).

## Project Structure

```text
DotNetTestingLab/
├── LICENSE
├── README.md
├── .gitignore
├── StringManipulation/                 # Module 0 — base console app (no tests yet)
│   ├── StringManipulation.sln
│   ├── StringManipulation.csproj
│   ├── Program.cs                      # Console entry point and menu
│   ├── StringOperations.cs             # Core logic that will be unit tested
│   ├── IFileReaderConnector.cs         # File reader abstraction + implementation
│   └── information.txt                 # Sample data file used by the "read file" option
└── StringManipulation.Tests/           # Module 1 — first xUnit test project
    ├── StringManipulation.Tests.csproj # net8.0, ProjectReference -> StringManipulation.csproj
    ├── StringOperationsTest.cs         # +ConcatenateStrings/IsPalindrome (M1-2) +QuantintyInWords/GetStringLength_Exception (M3)
    ├── UnitTest1.cs                    # Default xUnit template scaffold (unused, left as-is)
    └── Usings.cs                       # global using Xunit;
```

### Module 0 — Codebase

The starting point of the course. A single console project, `StringManipulation`, exposing a menu-driven app that performs basic string operations. No test project exists yet at this stage — it is added in later modules.

| File | Responsibility |
|------|-----------------|
| `Program.cs` | Renders the console menu and dispatches the selected option to `StringOperations`. |
| `StringOperations.cs` | Business logic for all string operations — the main subject under test in upcoming modules. |
| `IFileReaderConnector.cs` | Abstraction (`IFileReaderConnector`) and implementation (`FileReaderConnector`) for reading text files, isolated behind an interface to make it mockable in future tests. |
| `information.txt` | Sample file consumed by the "read text file" menu option. |

### Module 1 — First Test

Branch [`1-firsttest`](https://github.com/CristianSifuentes/DotNetTestingLab/tree/1-firsttest) introduces the repo's **first xUnit test project**, `StringManipulation.Tests`, and proves out the whole toolchain end to end: scaffold the project, reference the library under test, write one passing `[Fact]`, and document the CLI flow. Three commits carry the entire module:

| Commit | Message | What it actually did |
|--------|---------|------------------------|
| `125d095` | Adding StringManipulation.Tests project | Scaffolds the test project (the `dotnet new xunit` template) and writes the **first real test**, `StringOperationsTest.ConcatenateStrings`, against the existing `StringOperations.ConcatenateStrings`. Also swaps the README's sample value from `"Hello, Platzi"` to `"Hello, World"`, and the lesson's resource link from `platzi/curso-unit-testing-csharp` to `World/curso-unit-testing-csharp`, the generic naming used from this point on. |
| `0af72a3` | Change net8.0 | Fixes `StringManipulation.Tests.csproj`'s `TargetFramework`, which the template had scaffolded as `net7.0`, to `net8.0` — aligning it with the main `StringManipulation` project so both ends of the upcoming `ProjectReference` build against the same framework. |
| `236a5f3` | Creating new section in README.md | Documents the scaffold-reference-test flow in [How do you set this up from the .NET CLI (Visual Studio Code)?](#how-do-you-set-this-up-from-the-net-cli-visual-studio-code). |

| File | Responsibility |
|------|-----------------|
| `StringManipulation.Tests.csproj` | Test project file. Targets `net8.0`, sets `IsTestProject=true`, and pulls in `Microsoft.NET.Test.Sdk 17.3.2`, `xunit 2.4.2`, `xunit.runner.visualstudio 2.4.5`, and `coverlet.collector 3.1.2`. Its `<ProjectReference>` to `../StringManipulation/StringManipulation.csproj` is what makes `StringOperations` visible from test code. |
| `StringOperationsTest.cs` | The module's real deliverable: a `public class StringOperationsTest` with one `[Fact]`, `ConcatenateStrings`, following Arrange-Act-Assert to confirm `ConcatenateStrings("Hello", "World")` returns `"Hello World"` via `Assert.Equal` (see [How do you write a unit test step by step?](#how-do-you-write-a-unit-test-step-by-step)). |
| `UnitTest1.cs` | Leftover scaffold from the `dotnet new xunit` template — an empty `Test1` `[Fact]` inside a `UnitTest1` class. Left untouched in the tree; harmless, but dead weight a later cleanup pass should remove. |
| `Usings.cs` | `global using Xunit;` — keeps a bare `using Xunit;` out of every test file. |

**Evolutionary changes vs. Module 0:**

- **Added** — the entire `StringManipulation.Tests/` project (4 files). Module 0 shipped with zero test coverage; this is the first test project to exist in the repository.
- **Changed** — `StringManipulation.Tests.csproj`'s `TargetFramework` moved `net7.0` → `net8.0` within the module itself (`0af72a3`), correcting a template default so the test project's TFM matches `StringManipulation.csproj` (see [What .NET version is used, and does it work with newer versions?](#what-net-version-is-used-and-does-it-work-with-newer-versions)).
- **Unchanged** — every file under `StringManipulation/` (`Program.cs`, `StringOperations.cs`, `IFileReaderConnector.cs`, `information.txt`) is byte-for-byte identical to Module 0. This module adds test coverage without touching production code, the same separation of concerns described in [Why separate the test project from the main project?](#why-separate-the-test-project-from-the-main-project).
- **Not wired up** — `StringManipulation/StringManipulation.sln` was **not** updated to include `StringManipulation.Tests`; the `.sln` is byte-for-byte identical to Module 0. In practice, `dotnet test` still works from the `StringManipulation.Tests/` folder (or by pointing at its `.csproj` directly), but opening `StringManipulation.sln` in Visual Studio won't show the test project in Solution Explorer. That's a real discrepancy from the combined-solution walkthrough in [How do you set this up from the .NET CLI (Visual Studio Code)?](#how-do-you-set-this-up-from-the-net-cli-visual-studio-code) — worth closing with a `dotnet sln add` in a later module.

### Module 2 — Types Assert

Branch [`2-types-assert`](https://github.com/CristianSifuentes/DotNetTestingLab/tree/2-types-assert) adds no new project — it deepens the single test file from Module 1, `StringOperationsTest.cs`, putting the **AAA structure** into explicit inline comments and introducing **multi-assert tests** and the **boolean true/false pairing pattern**. Two commits carry the module:

| Commit | Message | What it actually did |
|--------|---------|------------------------|
| `2d31099` | Add info for Best Practices and Assert Types in xUnit | Documents AAA, the FIRST principles, multi-assert tests, and the true/false naming convention in the new [Best Practices and Assert Types in xUnit](#best-practices-and-assert-types-in-xunit) lesson — README only, no code changes. |
| `b017255` | Adding new code in StringOperationsTest | Implements what the lesson documents: strengthens `ConcatenateStrings` with two extra assertions and adds `IsPalindrome_True` / `IsPalindrome_False` as two independent `[Fact]` tests. |

| File | Change |
|------|--------|
| `StringOperationsTest.cs` | `ConcatenateStrings` gains `// Act` / `// Assert` comments and two assertions inserted **ahead of** the original `Assert.Equal("Hello World", result)`: `Assert.NotNull(result)` and `Assert.NotEmpty(result)` (see [How do you cover more scenarios with multiple asserts?](#how-do-you-cover-more-scenarios-with-multiple-asserts)). Two new `[Fact]` tests are added — `IsPalindrome_True` (`IsPalindrome("ama")` → `Assert.True`) and `IsPalindrome_False` (`IsPalindrome("hello")` → `Assert.False`) — one method per boolean outcome, following the `Method_Scenario` naming convention from [How do you test functions that return true or false?](#how-do-you-test-functions-that-return-true-or-false). |

**Evolutionary changes vs. Module 1:**

- **Changed** — `StringOperationsTest.cs` only (+30 lines, 0 deletions). Every other file — `UnitTest1.cs`, `Usings.cs`, both `.csproj` files, and everything under `StringManipulation/` — is byte-for-byte identical to Module 1.
- **Test count** — went from 1 discoverable `[Fact]` (`ConcatenateStrings`) to 3 (`ConcatenateStrings`, `IsPalindrome_True`, `IsPalindrome_False`), plus the still-unused template `UnitTest1.Test1` carried over from Module 1.
- **Depth, not breadth, on the existing test** — `ConcatenateStrings` wasn't rewritten; the original `Assert.Equal` line is untouched, and the new `Assert.NotNull`/`Assert.NotEmpty` calls were layered in front of it, so a future failure narrows down to "wrong value" only once "null" and "empty" are already ruled out.
- **Inconsistent AAA comments** — `b017255` adds `// Act` and `// Assert` to `ConcatenateStrings` but not `// Arrange` (the `var strOperations = new StringOperations();` line stays uncommented), while both new `IsPalindrome_*` tests carry all three. A cosmetic inconsistency, not a functional one — worth a follow-up cleanup pass.
- **Lesson ahead of test coverage** — the README's [What happens if you force a test to fail?](#what-happens-if-you-force-a-test-to-fail) and the [`RemoveWhitespace` practice challenge](#practice-challenge-testing-removewhitespace) are documented in this module's lesson text, but neither has a corresponding test committed to `StringOperationsTest.cs` yet — they're left as an exercise for whoever picks up the next module.

### Module 3 — Types Assert 2

Branch [`3-types-assert2`](https://github.com/CristianSifuentes/DotNetTestingLab/tree/3-types-assert2) is a single commit, `443acf0`, that does two things at once: it adds the [Testing with StartsWith, Contains, and Throws](#testing-with-startswith-contains-and-throws) lesson to the README, and it implements the two tests that lesson describes — `QuantintyInWords` and `GetStringLength_Exception` — in `StringOperationsTest.cs`. Like Module 2, no project files change; only the test file grows (+23 lines, 0 deletions).

| File | Change |
|------|--------|
| `StringOperationsTest.cs` | Two new `[Fact]` tests appended after `IsPalindrome_False`: `QuantintyInWords` calls `QuantintyInWords("cat", 10)` and checks the result two ways — `Assert.StartsWith("ten", result)` and `Assert.Contains("cat", result)` — instead of a single `Assert.Equal`, per [How do you test that a string starts with a given word?](#how-do-you-test-that-a-string-starts-with-a-given-word). `GetStringLength_Exception` wraps `GetStringLength(null)` in a lambda and asserts it throws, confirming the guard clause in `StringOperations.GetStringLength` (see [Features](#features)). |

**Evolutionary changes vs. Module 2:**

- **Changed** — `StringOperationsTest.cs` only (+23 lines). `UnitTest1.cs`, `Usings.cs`, both `.csproj` files, the `.sln`, and every file under `StringManipulation/` remain byte-for-byte identical to Module 2.
- **Test count** — went from 3 discoverable `[Fact]` tests to 5: `ConcatenateStrings`, `IsPalindrome_True`, `IsPalindrome_False`, `QuantintyInWords`, `GetStringLength_Exception` (plus the still-unused `UnitTest1.Test1`).
- **New assertion vocabulary** — this is the first module to move past `Assert.Equal`/`Assert.True`/`Assert.NotNull`/`Assert.NotEmpty`: `Assert.StartsWith` and `Assert.Contains` validate a *fragment* of the result rather than the whole string, and `GetStringLength_Exception` is the first exception-path test in the suite.
- **Code vs. README drift on the exception assertion** — the committed test calls `Assert.ThrowsAny<ArgumentNullException>(...)`, but the README's code sample for the same test (in [How do you test that a function throws an exception?](#how-do-you-test-that-a-function-throws-an-exception)) shows `Assert.Throws<ArgumentNullException>(...)`. They behave the same here only because `StringOperations.GetStringLength` throws the exact type `ArgumentNullException` and not a subclass — `Throws<T>` requires an exact type match, while `ThrowsAny<T>` also accepts derived exception types. Worth reconciling so the documented snippet matches the real assertion used.
- **AAA comments still inconsistent** — `QuantintyInWords` keeps `// Arrange` / `// Act` / `//Assert` (note the missing space before `Assert`, unlike every other test's `// Assert`), while `GetStringLength_Exception` has no AAA comments at all — consistent with the pattern from Module 2 ([Can you still apply AAA in exception tests?](#can-you-still-apply-aaa-in-exception-tests) explains why exception tests skip the **Act** step, but the missing **Arrange** comment here is just an omission).
- **Practice challenge still open** — [Practice challenge: testing TruncateString](#practice-challenge-testing-truncatestring) is documented but, like Module 2's `RemoveWhitespace` challenge, has no test in `StringOperationsTest.cs` yet.

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
