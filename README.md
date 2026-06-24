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
  - [How do xUnit, NUnit, and MSTest compare architecturally?](#how-do-xunit-nunit-and-mstest-compare-architecturally)
  - [What are the architectural advantages of xUnit?](#what-are-the-architectural-advantages-of-xunit)
  - [What are the architectural disadvantages of xUnit?](#what-are-the-architectural-disadvantages-of-xunit)
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
- [The Skip Attribute in xUnit](#the-skip-attribute-in-xunit)
  - [What does the Skip attribute do in xUnit, and when should you use it?](#what-does-the-skip-attribute-do-in-xunit-and-when-should-you-use-it)
  - [How do you apply Skip to a test step by step?](#how-do-you-apply-skip-to-a-test-step-by-step)
  - [Why should you create a backlog ticket when you skip a test?](#why-should-you-create-a-backlog-ticket-when-you-skip-a-test)
  - [What happens when you run tests with Skip enabled?](#what-happens-when-you-run-tests-with-skip-enabled)
  - [How do xUnit attributes translate to NUnit and MSTest?](#how-do-xunit-attributes-translate-to-nunit-and-mstest)
  - [What do you do when an assertion you need doesn't exist in xUnit?](#what-do-you-do-when-an-assertion-you-need-doesnt-exist-in-xunit)
- [Mocking Dependencies with Moq in .NET](#mocking-dependencies-with-moq-in-net)
  - [What is a mock, and why do you need one in your tests?](#what-is-a-mock-and-why-do-you-need-one-in-your-tests)
  - [How do mocks work when a component has several dependencies?](#how-do-mocks-work-when-a-component-has-several-dependencies)
  - [What happens if you test with real dependencies?](#what-happens-if-you-test-with-real-dependencies)
  - [How do you use the Moq library to simulate dependencies in .NET?](#how-do-you-use-the-moq-library-to-simulate-dependencies-in-net)
  - [What should you actually test in a service?](#what-should-you-actually-test-in-a-service)
  - [How do you simulate a database and a logging system with Moq?](#how-do-you-simulate-a-database-and-a-logging-system-with-moq)
- [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c)
  - [Why does a unit test fail when it has external dependencies?](#why-does-a-unit-test-fail-when-it-has-external-dependencies)
  - [How do you debug a failing test with the Visual Studio debugger?](#how-do-you-debug-a-failing-test-with-the-visual-studio-debugger)
  - [How do you install the Moq library in a test project?](#how-do-you-install-the-moq-library-in-a-test-project)
  - [How do you mock a dependency with Moq step by step?](#how-do-you-mock-a-dependency-with-moq-step-by-step)
  - [How do you verify that the unit test passes correctly?](#how-do-you-verify-that-the-unit-test-passes-correctly)
  - [When should you use mocks instead of real objects?](#when-should-you-use-mocks-instead-of-real-objects)
- [Simulating Dependencies and Behavior with Mock in Unit Tests](#simulating-dependencies-and-behavior-with-mock-in-unit-tests)
  - [Why isn't it enough to create a mock with no configuration?](#why-isnt-it-enough-to-create-a-mock-with-no-configuration)
  - [How do you configure a mock's behavior with Setup?](#how-do-you-configure-a-mocks-behavior-with-setup)
  - [What happens if the parameter doesn't match the setup?](#what-happens-if-the-parameter-doesnt-match-the-setup)
  - [How do you accept any parameter with It.IsAny?](#how-do-you-accept-any-parameter-with-itisany)
  - [When does it make sense to simulate complex logic in a dependency?](#when-does-it-make-sense-to-simulate-complex-logic-in-a-dependency)
- [Test Coverage with Coverlet in .NET](#test-coverage-with-coverlet-in-net)
  - [What is unit test coverage, and what is it for?](#what-is-unit-test-coverage-and-what-is-it-for)
  - [What tools exist to measure coverage in .NET?](#what-tools-exist-to-measure-coverage-in-net)
  - [Why is Coverlet the best option for modern .NET?](#why-is-coverlet-the-best-option-for-modern-net)
  - [What technical advantages does Coverlet offer?](#what-technical-advantages-does-coverlet-offer)
  - [How do you install and use Coverlet in your project?](#how-do-you-install-and-use-coverlet-in-your-project)
- [Running Coverlet and Reading Its Coverage Report](#running-coverlet-and-reading-its-coverage-report)
  - [Which Coverlet packages do you actually need to install?](#which-coverlet-packages-do-you-actually-need-to-install)
  - [How do you install Coverlet.Console as a global tool?](#how-do-you-install-coverletconsole-as-a-global-tool)
  - [How do you run the coverage command with dotnet test?](#how-do-you-run-the-coverage-command-with-dotnet-test)
  - [How do you interpret line, branch, and method percentages?](#how-do-you-interpret-line-branch-and-method-percentages)
  - [Why is the branches metric the most important one?](#why-is-the-branches-metric-the-most-important-one)
- [Troubleshooting Coverlet Coverage Output](#troubleshooting-coverlet-coverage-output)
  - [Why does dotnet test run but never print a coverage table?](#why-does-dotnet-test-run-but-never-print-a-coverage-table)
  - [Why might the pinned coverlet.console version matter?](#why-might-the-pinned-coverletconsole-version-matter)
  - [Is there a way to get coverage without coverlet.msbuild at all?](#is-there-a-way-to-get-coverage-without-coverletmsbuild-at-all)
  - [How do you turn the raw XML report into a readable HTML report?](#how-do-you-turn-the-raw-xml-report-into-a-readable-html-report)
  - [What if the packages are installed but the percentages still don't show up?](#what-if-the-packages-are-installed-but-the-percentages-still-dont-show-up)
- [Filtering Coverage with Include and ExcludeFromCodeCoverage](#filtering-coverage-with-include-and-excludefromcodecoverage)
  - [Why isn't your initial coverage percentage realistic?](#why-isnt-your-initial-coverage-percentage-realistic)
  - [How do you filter by namespace with the Include parameter?](#how-do-you-filter-by-namespace-with-the-include-parameter)
  - [How do you exclude classes with ExcludeFromCodeCoverage?](#how-do-you-exclude-classes-with-excludefromcodecoverage)
  - [How do you activate it from the command with ExcludeByAttribute?](#how-do-you-activate-it-from-the-command-with-excludebyattribute)
  - [Can ExcludeFromCodeCoverage be applied to Main itself?](#can-excludefromcodecoverage-be-applied-to-main-itself)
  - [Does ExcludeFromCodeCoverage couple your production code to the test framework?](#does-excludefromcodecoverage-couple-your-production-code-to-the-test-framework)
  - [What coverage percentage should you actually aim for?](#what-coverage-percentage-should-you-actually-aim-for)
- [Visual Coverage Reports with ReportGenerator and FineCodeCoverage](#visual-coverage-reports-with-reportgenerator-and-finecodecoverage)
  - [How do you export coverage to a standard XML file?](#how-do-you-export-coverage-to-a-standard-xml-file)
  - [Why use the Cobertura format instead of something else?](#why-use-the-cobertura-format-instead-of-something-else)
  - [How do you generate an HTML report with ReportGenerator?](#how-do-you-generate-an-html-report-with-reportgenerator)
  - [What information can you see in the HTML report?](#what-information-can-you-see-in-the-html-report)
  - [How do you view coverage without leaving Visual Studio with FineCodeCoverage?](#how-do-you-view-coverage-without-leaving-visual-studio-with-finecodecoverage)
  - [How do you configure FineCodeCoverage to exclude classes?](#how-do-you-configure-finecodecoverage-to-exclude-classes)
- [What You Learned in This Course: From Asserts to Coverage](#what-you-learned-in-this-course-from-asserts-to-coverage)
  - [What did you learn about unit testing in xUnit?](#what-did-you-learn-about-unit-testing-in-xunit)
  - [Why do Mock and coverage matter in your tests?](#why-do-mock-and-coverage-matter-in-your-tests)
  - [How do you keep practicing after the course?](#how-do-you-keep-practicing-after-the-course)
  - [What topics might come up in a job interview?](#what-topics-might-come-up-in-a-job-interview)
  - [What's the next step to master testing in .NET?](#whats-the-next-step-to-master-testing-in-net)
- [Module Roadmap](#module-roadmap)
- [Project Structure](#project-structure)
  - [Module 0 — Codebase](#module-0--codebase)
  - [Module 1 — First Test](#module-1--first-test)
  - [Module 2 — Types Assert](#module-2--types-assert)
  - [Module 3 — Types Assert 2](#module-3--types-assert-2)
  - [Module 4 — Theory InlineData](#module-4--theory-inlinedata)
  - [Module 5 — Skip](#module-5--skip)
  - [Module 6 — Moq Library](#module-6--moq-library)
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

### How do xUnit, NUnit, and MSTest compare architecturally?

Beyond naming, the three libraries differ in default behaviors that shape how you design tests — especially around instance lifecycle and execution order:

| Feature | xUnit.net | NUnit | MSTest |
|---|---|---|---|
| Instance lifecycle | New instance per test method | One instance per class (by default) | New instance per test method |
| Test execution | Parallel by default (at assembly level) | Sequential by default | Sequential by default |
| Basic test attribute | `[Fact]` | `[Test]` | `[TestMethod]` |
| Parameterized test | `[Theory]` + `[InlineData]` | `[TestCase]` | `[DataRow]` |
| Setup mechanism | Class constructor | `[SetUp]` method | `[TestInitialize]` method |
| Teardown mechanism | `IDisposable` (`Dispose`) | `[TearDown]` method | `[TestCleanup]` method |

> **Why does xUnit use the constructor and `Dispose` instead of `[SetUp]`/`[TearDown]` attributes?** Because xUnit favors native C# idioms over framework-specific lifecycle attributes: code that needs to run before a test belongs in the class constructor, and cleanup code belongs in `Dispose()` — the same pattern you'd use for any disposable resource in plain C#, with no extra attribute vocabulary to learn.

### What are the architectural advantages of xUnit?

xUnit's defaults aren't arbitrary — each one solves a specific problem that surfaces once a test suite grows large:

- **Strict test isolation** — xUnit instantiates a brand-new test class object for every single test case it runs (see [Isolated lifecycles](#what-are-the-core-characteristics-of-fact)). This entirely eliminates state-leakage issues where one test accidentally mutates a shared class-level field and breaks a subsequent one.
- **Built-in parallelism** — it leverages multi-core processors out of the box by automatically running test collections in parallel, giving excellent execution speed on large test suites without any extra configuration.
- **Native language idioms** — instead of relying on proprietary framework attributes for lifecycle management, xUnit relies on standard object-oriented C# patterns: setup code goes into the constructor, cleanup code goes into `Dispose()`.
- **Clean syntax** — it strips away boilerplate attributes like `[TestFixture]` or `[TestClass]`. A class is recognized as a test container simply by containing test methods, as long as it's `public` (see [Why must the test class be public?](#how-do-you-write-a-unit-test-step-by-step)).

### What are the architectural disadvantages of xUnit?

The same defaults that make xUnit powerful also introduce friction in specific scenarios:

- **Steeper learning curve** — developers moving from traditional frameworks like JUnit or NUnit often struggle initially with the absence of explicit setup/teardown attributes and the strict per-test instance lifecycle.
- **Complex shared context** — if you intentionally want to share expensive state across tests, such as an in-memory database connection or a Docker container, you must implement specialized patterns like `IClassFixture<T>` or `ICollectionFixture<T>` (see [the class fixtures callout](#what-are-the-core-characteristics-of-fact)) rather than relying on a simple shared field.
- **Integration testing friction** — while outstanding for isolated unit tests, xUnit's default behaviors (new instance per test, parallel execution) can make complex integration or sequential regression workflows harder to orchestrate than with frameworks that default to sequential, class-shared execution.

These trade-offs are exactly why this course reaches for xUnit on unit tests specifically: the isolation and parallelism that make it awkward for some integration scenarios are the same properties that make it reliable for the fast, independent tests the [FIRST principles](#what-are-the-first-principles-of-testing) call for.

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

## The Skip Attribute in xUnit

When a unit test fails for reasons that have nothing to do with your code's logic — a library upgrade, an architecture change, a flaky external dependency — you need a graceful way out. xUnit's `Skip` named parameter lets you pause that test without breaking your continuous integration pipeline, buying you time to resolve the real problem calmly instead of reacting to a wall of red.

### What does the Skip attribute do in xUnit, and when should you use it?

`Skip` works like a temporary pause button for a test you can't run right now but don't want to delete either.

Picture this scenario: your unit tests are automated and, suddenly, one of them starts failing because you upgraded a dependency. If you do nothing, every single run reports an error — and fixing the root cause might take days, since it depends on something external rather than your own logic.

That's where `Skip` comes in. You add it as a named parameter inside `[Fact]`, and it takes a text value that must justify *why* you're skipping the test.

> **What is the Skip attribute in xUnit?** A named parameter you add inside `[Fact]` so a specific test doesn't run. It takes a text message explaining the reason for the skip.

### How do you apply Skip to a test step by step?

Inside your test file — `StringOperationsTest`, in this repo's case — you locate the test you want to pause and modify its attribute:

```csharp
[Fact(Skip = "This test is not valid at this time. Ticket 001")]
public void ConcatenateStrings_ShouldReturnConcatenatedString()
{
    // test logic
}
```

A generic message like "this test isn't valid right now" doesn't help much. The strong recommendation is to give it real context and link it to a ticket in your backlog, so anyone reading the code knows there's a formal follow-up in place.

This repo's own `ConcatenateStrings` test (see [How do you write a unit test step by step?](#how-do-you-write-a-unit-test-step-by-step)) follows exactly that pattern: `[Fact(Skip = "This test is not valid at this time, TICKET-001")]`.

### Why should you create a backlog ticket when you skip a test?

Because without a ticket, `Skip` tends to become permanent — and a test that's skipped forever is noise in your suite, not coverage.

By referencing something like `TICKET-001` in the message, you connect the technical decision to your tracking system, whether that's Jira, Azure DevOps, or whatever your team uses. That guarantees someone will pick the problem back up, fix it, and remove the attribute so the test runs again like all the others.

### What happens when you run tests with Skip enabled?

It doesn't matter whether you run your tests from Visual Studio or from the CLI with `dotnet test` — the behavior is the same: the marked test is omitted, and the report tells you so.

- In **Visual Studio**, you'll see a warning indicating the test was skipped during the run.
- In the **terminal**, the CLI's report shows something like eight tests passed and one skipped, along with the message you wrote as justification.

That visibility matters: a failing test and an intentionally skipped one are not the same thing, and xUnit makes that distinction clear in both environments.

### How do xUnit attributes translate to NUnit and MSTest?

xUnit's own documentation publishes a comparison table against the other two popular .NET frameworks. The good news: everything you learn in xUnit carries over to the other two — only the naming changes.

A few key equivalences:

| Concept | xUnit | NUnit | MSTest |
|---|---|---|---|
| Test attribute | `[Fact]` | `[Test]` | `[TestMethod]` |
| Equality assertion | `Assert.Equal` | `Is.EqualTo` (via `Assert.That`) | `Assert.AreEqual` |

> **What's the difference between xUnit, NUnit, and MSTest?** All three are .NET testing frameworks with the same underlying functionality. Attribute and assertion names change, but the unit testing concepts behind them are identical (see [Unit Testing Libraries in .NET: MSTest, NUnit, and xUnit](#unit-testing-libraries-in-net-mstest-nunit-and-xunit) for a deeper comparison).

### What do you do when an assertion you need doesn't exist in xUnit?

Sometimes you run into cases where there's no assertion method built for exactly what you want to check. For example, xUnit has no dedicated assertion for verifying that a `double` is `NaN`. Instead, you combine existing methods:

```csharp
Assert.True(double.IsNaN(result));
```

The same idea applies to checking assignable types — if there's no direct method for it, you combine `Assert.False`/`Assert.True` with a type check instead. The underlying philosophy holds across the board: whatever you can do in other testing libraries, you can do in xUnit too — only the syntax changes.

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `5-skip`.

## Mocking Dependencies with Moq in .NET

When you start writing unit tests in .NET, you quickly run into a problem: your code depends on things you don't control — databases, cloud services, third-party libraries. This is where the concept of a **mock** comes in: a technique that lets you simulate those dependencies so your tests focus only on the logic you actually wrote. This lesson introduces **Moq**, the most widely used mocking library in .NET, as the tool for the job.

### What is a mock, and why do you need one in your tests?

A **mock** is an imitated or simulated object that replaces a real dependency inside your code during a test run. The goal is to keep your test from depending on external elements you can't control.

Those dependencies can take many shapes:

- AWS or Azure services.
- Third-party libraries outside your project.
- External classes, interfaces, or abstract classes.
- Database connections.

The rule is simple: you simulate what you don't control, and you leave the real code in place for what does belong to your project. That way, your test measures your own logic, not the outside world's.

> **What is a mock in unit testing?** It's an object that imitates the behavior of a real dependency, returning predefined data or responses so your test runs without ever touching the original service.

### How do mocks work when a component has several dependencies?

Picture a component with two external dependencies. Instead of letting your test connect to those real services, you turn both dependencies into mocks — objects that return a specific value or simulate a concrete behavior.

A very common case is the database. A unit test shouldn't depend on a real database. If your code runs a query, what you do is create a mock that simulates the result of that query, and then validate your logic against that simulated value. The test becomes fast, repeatable, and it doesn't fail just because the database happens to be down.

### What happens if you test with real dependencies?

Your test stops being a unit test. It starts depending on the network, the state of a real database, credentials, and services that can change at any moment. The result: slow, fragile tests that are hard to reproduce — exactly what the [FIRST principles](#what-are-the-first-principles-of-testing) warn you against, since a test tied to a live dependency can no longer be **Fast**, **Independent**, or **Repeatable**.

### How do you use the Moq library to simulate dependencies in .NET?

**Moq** is the most popular library in .NET for creating mocks. It lets you define how a simulated dependency should behave inside your tests, without ever touching production code.

Think of a realistic scenario: a task service consumed from an API or a web project. That service typically has two dependencies:

- **Entity Framework**, the most widely used ORM in .NET, for connecting to the database.
- A **logging service** that records events such as queries, updates, and saves.

Neither one is part of the logic you actually want to test — what matters is validating the service's own behavior.

### What should you actually test in a service?

The logic that you wrote and control. For example:

- Whether the service runs a query and then applies a filter over the results.
- Whether the service sorts a list after fetching it from the database.
- Whether the service looks up an item inside a collection and applies a change to it.

That's what belongs in a unit test. *How* the service connects to the database or *how* it writes to the log stays out of scope — it isn't your business logic.

### How do you simulate a database and a logging system with Moq?

With Moq you can inject mocks that replace Entity Framework and the logging system. A frequent option is an **in-memory database**, where the test framework spins up a simulated database that your code interacts with as if it were real.

For logging, the strategy is usually different. Logging exists to collect data and metrics, but it doesn't affect the product's logic. That's why the logger's mock typically does nothing: you inject it as a dependency, the service believes it's recording events, and your test simply ignores that step.

> **Why isn't logging tested in unit tests?** Because unit tests validate business logic, and logging is an auxiliary observability system that doesn't affect the functional outcome of the code.

> **When should you use an in-memory database with Moq?** When your code needs to interact with an Entity Framework context during the test, but without connecting to a real database. The in-memory database simulates that behavior within the test process itself.

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `6-libreriamoq`.

## Mocking ILogger with Moq in C#

A function that mixes business logic with a utility like a logger becomes awkward to test: your unit test fails over a dependency you don't even want to validate. This lesson walks through `CountOccurrences` (see [Features](#features)) step by step, showing how to isolate its logic from the `ILogger<StringOperations>` dependency injected into `StringOperations`'s constructor, using a Moq mock.

### Why does a unit test fail when it has external dependencies?

`CountOccurrences` walks the input string with a `foreach`, counts how many characters match, and returns an `int` — pure logic, so far. The complication is one extra line: a call to `_logger.LogInformation` that records how many occurrences were found.

That logger is a generic utility, not part of the business logic. But if you instantiate `StringOperations` with its parameterless constructor — the one that never assigns `_logger` — the field stays `null`, and the moment `CountOccurrences` reaches `_logger.LogInformation`, the test blows up with a `NullReferenceException` that has nothing to do with the counting logic itself.

> **What is a mock in unit testing?** A fictitious object that simulates the behavior of a real dependency. It doesn't run the original logic — it just pretends to exist so your test can run without touching external services.

### How do you debug a failing test with the Visual Studio debugger?

When a test fails for no obvious reason, Visual Studio's **Debug Test** feature is what saves you. The process:

1. Set a breakpoint on the line where you instantiate the object under test.
2. Right-click the test method and choose **Debug Test**.
3. Step through the code with the debugger's controls.
4. Inspect variables and watch where the flow breaks.

Stepping into `CountOccurrences`, the `foreach` counts correctly — the break happens the instant the method tries to use `logger`. The cause: the dependency arrives `null` because nothing ever injected it.

### How do you install the Moq library in a test project?

Moq is installed from the **test project's** NuGet package manager, not the main project's. In Visual Studio:

1. Open **Solution Explorer** and select the test project (`StringManipulation.Tests` in this repo).
2. Open **Manage NuGet Packages**.
3. Go to the **Browse** tab and search for `Moq`.
4. Pick the first result, accept the license, and click **Install**.

Alternatives like AutoFixture or AutoMock exist, but Moq is the most popular mocking library in C# and the one you'll run into in most .NET projects. From Visual Studio Code or the .NET CLI, the equivalent is:

```bash
dotnet add StringManipulation.Tests/StringManipulation.Tests.csproj package Moq
```

This repo's `StringManipulation.Tests.csproj` now references **Moq `4.18.4`** alongside `Microsoft.NET.Test.Sdk`, `xunit`, `xunit.runner.visualstudio`, and `coverlet.collector` (see [Tech Stack](#tech-stack)).

### How do you mock a dependency with Moq step by step?

`StringOperations` exposes a constructor overload that takes an `ILogger<StringOperations>`. The fix is to create a mock of that interface and pass its `.Object` to the constructor, inside the **Arrange** step of AAA (see [What is the AAA (Arrange-Act-Assert) structure?](#what-is-the-aaa-arrange-act-assert-structure)):

```csharp
[Fact]
public void CountOccurrences()
{
    var mockLogger = new Mock<ILogger<StringOperations>>();
    var strOperations = new StringOperations(mockLogger.Object);

    var result = strOperations.CountOccurrences("Hello platzi", 'l');

    Assert.Equal(3, result);
}
```

Two details change everything here: `mockLogger` has to be declared **before** instantiating `StringOperations`, since that class receives the dependency through its constructor. And you pass `mockLogger.Object`, not the mock itself — `.Object` is where the simulated instance that Moq generates internally actually lives.

> **What does `new Mock<T>()` do exactly?** It creates a fake object of type `T` that satisfies its contract without running any real logic. It lets the class under test receive the dependency without executing behavior you don't care about validating.

### How do you verify that the unit test passes correctly?

After installing Moq and rewriting the arrange step, running the test can surface a second, unrelated failure: `Assert.Equal` expecting `2` when the actual result is `3`. The fix isn't in the mock — it's in the expectation: `"Hello platzi"` contains three `l` characters (two in `"Hello"`, one in `"platzi"`), not two.

Adjusting the expected value to `3` makes the test pass. If you ever hit a compilation error or null-reference issue right after adding Moq, the usual fix is to rebuild the test project so the new package reference resolves correctly.

### When should you use mocks instead of real objects?

Reaching for a mock makes sense in specific scenarios:

- Dependencies that write to the console, files, or a database, like a logger.
- External services over HTTP that would slow the test down.
- Abstract interfaces whose real implementation doesn't contribute to the logic you're validating.
- Components with side effects that would leave the test environment dirty.

The core idea: a unit test should validate a single unit of logic without dragging in auxiliary behavior. Moq gives you exactly that clean boundary.

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `6-libreriamoq`.

## Simulating Dependencies and Behavior with Mock in Unit Tests

Simulating a dependency that does nothing is straightforward — that's exactly what the `ILogger<StringOperations>` mock in [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c) does. But what happens when the dependency returns a value the method under test actually depends on to keep running? This lesson covers `Setup`, `Returns`, and `It.IsAny<T>()` — the tools Moq gives you to configure exactly what a mock does when it's called — using `StringOperations.ReadFile` and its `IFileReaderConnector` dependency as the example.

### Why isn't it enough to create a mock with no configuration?

In [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c), creating `new Mock<ILogger<StringOperations>>()` with no further configuration was enough, because `ILogger` never returns a value that `CountOccurrences` depends on — it only records information as a side effect. Standing an unconfigured mock in for it changes nothing about the method's return value.

`ReadFile` (see [Features](#features)) is different:

```csharp
public string ReadFile(IFileReaderConnector fileReader, string fileName)
{
    return fileReader.ReadString(fileName);
}
```

`ReadFile` receives an `IFileReaderConnector`, uses it to read `fileName`, and returns exactly what that call produces. Here, the mocked dependency actively drives the return value the test asserts against. An unconfigured `Mock<IFileReaderConnector>` returns `null` from `ReadString` by default — and a test asserting against that `null` would never reflect the real logic the method is supposed to execute.

### How do you configure a mock's behavior with Setup?

Moq's `Setup` method defines what a simulated method should do when it's invoked with specific parameters, and `Returns` defines the value it hands back:

```csharp
var mockFileReader = new Mock<IFileReaderConnector>();

mockFileReader
    .Setup(fr => fr.ReadString("file.txt"))
    .Returns("reading file");

var strOperations = new StringOperations();
var result = strOperations.ReadFile(mockFileReader.Object, "file.txt");

Assert.Equal("reading file", result);
```

> 📌 The original lesson script names the mocked method `ReadStream`; this repo's actual `IFileReaderConnector` interface (see [Module 0 — Codebase](#module-0--codebase)) declares it as `ReadString`. The snippet above uses the real member name so it compiles against this codebase — the `Setup`/`Returns`/`It.IsAny` mechanics described are identical either way.

Four things happen in that block:

1. A `Mock<IFileReaderConnector>` is created.
2. `Setup` tells Moq: when `ReadString` is called with `"file.txt"`, intercept it.
3. `Returns` tells Moq what to hand back when that match happens — `"reading file"`.
4. `mockFileReader.Object` — the simulated instance, not the mock wrapper itself — is passed into `ReadFile`, the same way [`CountOccurrences`](#how-do-you-mock-a-dependency-with-moq-step-by-step) passes `mockLogger.Object`.

The dependency never touches a real file. It believes it's reading `"file.txt"`, but it returns exactly what `Setup`/`Returns` configured — keeping the test independent of the filesystem, in line with the [FIRST principles](#what-are-the-first-principles-of-testing).

### What happens if the parameter doesn't match the setup?

`Setup` matching is strict by default. If the test calls `ReadFile(mockFileReader.Object, "file2.txt")` while the mock is only configured for `"file.txt"`, Moq finds no matching setup and `ReadString` returns `null` — the same default an entirely unconfigured mock would produce. The mismatch is silent: nothing throws, the test simply receives a value it didn't expect.

### How do you accept any parameter with It.IsAny?

When the exact input doesn't matter — only the fact that *some* call happens — Moq's `It.IsAny<T>()` relaxes the match:

```csharp
mockFileReader
    .Setup(fr => fr.ReadString(It.IsAny<string>()))
    .Returns("reading file");
```

With this setup, `"file.txt"`, `"file2.txt"`, or any other string all produce the same `"reading file"` result. This is useful once a test wants to validate the logic that runs *after* the dependency returns its value, rather than the specific input passed into that dependency.

> **What does `It.IsAny<T>()` do in Moq?** It widens a `Setup` so it matches a call regardless of the argument passed, instead of requiring an exact value match.

### When does it make sense to simulate complex logic in a dependency?

In this example, `ReadFile` returns exactly what `IFileReaderConnector` gives it — a thin pass-through. In a real service, that same dependency could run a calculation, query a cloud API, or process a larger payload before returning anything. The principle doesn't change with the complexity: `Setup`/`Returns` (and `It.IsAny<T>()` when the input is irrelevant) let a unit test stay independent of physical files, external services, or any resource that lives outside the code actually under test.

Key points to remember:

- `Setup` defines which method call a mock should intercept, and with which parameters.
- `Returns` defines the value the mock hands back when that call matches.
- `It.IsAny<T>()` relaxes a `Setup` to match any argument of type `T`.
- An unconfigured mock — or a `Setup` whose parameters don't match the call — returns the default value for its return type (`null` for reference types).

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `6-libreriamoq`.

## Test Coverage with Coverlet in .NET

Unit test coverage is the metric that tells you how effective the tests you write with xUnit and tools like Moq actually are. If you already know how to build tests, this is the logical next step: measuring how much of your code's logic you're really validating, spotting the gaps, and focusing your effort where it matters most.

A single method can hide several paths at once — conditionals, `if`/`else` branches, calls into other functions. Measuring that complexity by hand would be impractical, so you need an automated tool that hands you a clear, actionable percentage.

### What is unit test coverage, and what is it for?

Coverage is a measurement that returns a percentage of how much of your code is actually executed by your tests. It isn't about writing more tests for the sake of it — it's about understanding where your logic is going unvalidated.

> **What coverage percentage is ideal for a .NET project?** Between 70% and 80% for typical applications. For a library or utility project — like this repo's own `StringManipulation` string-manipulation library (see [Features](#features)) — the bar is higher: above 90%.
>
> Reaching 100% is rarely realistic, since templated code, framework plumbing, and third-party libraries fall outside your own business logic. Even so, massive open-source libraries like React or Angular get close to that ceiling, precisely because they're consumed by thousands of people and every function needs to be proven correct.

### What tools exist to measure coverage in .NET?

The right tool depends on your IDE, your budget, and which .NET flavor you're targeting:

- **Analyze Code Coverage for All Tests** — built into Visual Studio Enterprise. Nothing extra to install, but it sits behind an expensive license, typically available only if your company is a Microsoft partner.
- **NCover** and **OpenCover** — older tools, still functional, but oriented toward the classic .NET Framework rather than modern .NET.
- **dotCover** — JetBrains' tool, bundled inside ReSharper. One click detects your tests, runs them, and returns a coverage percentage.
- **Fine Code Coverage** — a free Visual Studio extension funded by community donations. It builds on libraries like OpenCover or Coverlet under the hood, and works for both .NET Framework and modern .NET.

> **What's the difference between dotCover and Fine Code Coverage?** dotCover is a commercial JetBrains tool with its own analysis engine. Fine Code Coverage is free and delegates the actual report generation to open-source libraries such as Coverlet.

### Why is Coverlet the best option for modern .NET?

**Coverlet** is the library worth concentrating on. It's completely free, open source, and cross-platform — it runs the same on Windows, macOS, and Linux — and it's part of the .NET Core open-source library suite, which makes it the natural choice for modern applications like this repo's `StringManipulation` project.

Coverlet supports classic .NET Framework too, but it leans much more toward .NET and .NET Core. If you're working on a legacy .NET Framework app, NCover or OpenCover will likely serve you better; for anything built on modern .NET — this repo included (see [Tech Stack](#tech-stack)) — Coverlet is the way to go.

### What technical advantages does Coverlet offer?

Beyond being free, three strengths make Coverlet practical day to day:

- It works with any testing library — xUnit, NUnit, or MSTest — no lock-in to a specific framework (this repo already uses **xUnit**; see [Tech Stack](#tech-stack)).
- It can generate coverage reports by combining with additional reporting components.
- It exposes plenty of configuration parameters to fine-tune the percentage and exclude what you don't want measured.

### How do you install and use Coverlet in your project?

The setup is surprisingly small — just two NuGet packages, both added to your **test** project:

- `coverlet.msbuild`
- `coverlet.collector`

> 📌 This repo's `StringManipulation.Tests.csproj` already references **`coverlet.collector` `3.1.2`** — it's been there since [Module 1 — First Test](#module-1--first-test), bundled automatically by the `dotnet new xunit` template (see [How do you set this up from the .NET CLI (Visual Studio Code)?](#how-do-you-set-this-up-from-the-net-cli-visual-studio-code)). `coverlet.msbuild`, the package this lesson pairs it with for the `/p:CollectCoverage=true` workflow below, isn't referenced yet — installing it is the natural next step before running the command below against `StringManipulation.Tests`.

With both packages installed, you can pull a coverage report from Visual Studio through the Fine Code Coverage extension, or straight from the terminal with a single command:

```bash
dotnet test /p:CollectCoverage=true
```

> **How do you get test coverage with `dotnet test`?** Install the `coverlet.msbuild` and `coverlet.collector` packages, then run `dotnet test` with the `CollectCoverage=true` MSBuild property. The terminal prints the coverage percentage directly in the test run summary.

Two packages and one command — that's enough to get a real measurement of how thoroughly your code is tested, ready to be pointed at this repo's own `StringManipulation` project in a future module.

## Running Coverlet and Reading Its Coverage Report

Coverlet isn't a single package — it's a small family of tools, each covering a different stage of the workflow: collecting coverage during a test run, wiring that collection into MSBuild, and running it as a standalone CLI. This lesson walks through all three, and through reading the percentages they report, continuing directly from [Test Coverage with Coverlet in .NET](#test-coverage-with-coverlet-in-net).

### Which Coverlet packages do you actually need to install?

Three pieces make up the toolchain, and each does something different:

- **`coverlet.collector`** — ships by default with the xUnit project template (`dotnet new xunit`) and collects coverage data while the test run executes. This repo's `StringManipulation.Tests.csproj` has had it since [Module 1 — First Test](#module-1--first-test).
- **`coverlet.msbuild`** — installed from the NuGet package manager (or `dotnet add package coverlet.msbuild`), and is what lets `dotnet test` report coverage directly through an MSBuild property, from Visual Studio or the terminal.
- **`coverlet.console`** — a **global .NET tool**, not a project package. It's installed once per machine with `dotnet tool install`, not added to any `.csproj`.

> **Why does installing `coverlet.console` as a project NuGet package fail?** Because it isn't a project library — it's a global CLI tool. Installing it through the project's package manager throws an error; the correct path is `dotnet tool install --global coverlet.console`.

### How do you install Coverlet.Console as a global tool?

Coverlet.Console is installed once per machine, not per project:

```bash
dotnet tool install --global coverlet.console
```

Run that from a terminal (**View > Terminal** in Visual Studio, or any shell). If it's already installed, the CLI reports that. Otherwise it walks through the install and ends with a success message — after that, `coverlet` is available as a top-level command from any directory, not just from inside `StringManipulation.Tests`.

### How do you run the coverage command with dotnet test?

With the packages in place, running coverage from `StringManipulation.Tests` is the same `dotnet test` from [How do you run xUnit tests from the terminal?](#how-do-you-run-xunit-tests-from-the-terminal), with one extra MSBuild property:

```bash
dotnet test /p:CollectCoverage=true
```

`CollectCoverage=true` tells Coverlet to calculate coverage percentages on top of the regular test run and print them once the tests finish. In the lesson's own run, the result was **10 tests passed, 1 skipped**, followed by a table of percentages for the `StringManipulation` class.

> 📌 **Tried against this repo as it stands today:** running the exact command above from `StringManipulation.Tests` executes all 10 discoverable tests (`ConcatenateStrings` skipped, the rest passing or failing depending on locale — see [the `QuantintyInWords` culture callout](#how-do-you-test-that-a-string-starts-with-a-given-word)), but prints **no coverage table**. That confirms the gap flagged in the previous section: `coverlet.collector` alone doesn't hook into the `/p:CollectCoverage=true` MSBuild property — `coverlet.msbuild` does. Adding that package is what turns the command above from "just run the tests" into "run the tests and report coverage."

> **What does the `CollectCoverage` parameter do in `dotnet test`?** It turns on Coverlet's metrics collection during the test run and returns a table of line, branch, and method percentages once the run finishes — provided `coverlet.msbuild` is referenced in the test project.

### How do you interpret line, branch, and method percentages?

Coverlet's report breaks coverage into three distinct numbers, and each one tells you something different. In the lesson's example run against the course's `StringManipulation` class, the numbers were **23.95% lines**, **20% branches**, and **60% methods** — three metrics that look similar but measure very different things:

- **Line coverage** — the percentage of code lines that were actually executed while running the tests.
- **Method coverage** — how many of the class's functions were invoked at least once by some test.
- **Branch coverage** — how many logical paths — `if`s, conditions, alternate flows — were actually exercised.

Method coverage tends to look generous, since a single basic test is enough to mark an entire method as "covered." Branch coverage is the stricter, more meaningful number.

### Why is the branches metric the most important one?

A method can hide more than one path through it. Take this repo's own `TruncateString` (see [Features](#features)):

```csharp
public string TruncateString(string input, int maxLength)
{
    if (maxLength <= 0)
    {
        throw new ArgumentOutOfRangeException();
    }

    if (string.IsNullOrEmpty(input) || maxLength >= input.Length)
    {
        return input;
    }

    return input.Substring(0, maxLength);
}
```

That's three possible flows in a single method: the `ArgumentOutOfRangeException` guard, the early `return input`, and the final `Substring` truncation. Calling `TruncateString` with just one of those three inputs is already enough for **method coverage** to mark it "covered" — but branch coverage stays low, because the other two paths never ran.

The only way to raise that number is to read the code, identify every condition, and write a dedicated test for each path — exactly the gap the still-open [Practice challenge: testing `TruncateString`](#practice-challenge-testing-truncatestring) exists to close in this repo.

That's why, when coverage is part of your quality bar — with or without TDD — branches are the number that best reflects how robust your tests really are. A method count of 60% can comfortably coexist with a branch count of 20%, and that gap is exactly where your code's untested logic hides.

Key points to remember:

- `coverlet.collector` collects coverage during the test run and ships with the xUnit template; `coverlet.msbuild` is what surfaces that data through `dotnet test /p:CollectCoverage=true`; `coverlet.console` is a separate global CLI tool installed with `dotnet tool install`.
- Line, method, and branch coverage measure three different things — method coverage is the most forgiving, branch coverage the strictest.
- A high method-coverage percentage can mask a low branch-coverage percentage; branches are what actually tell you whether every `if` in your code has been exercised by a test.

## Troubleshooting Coverlet Coverage Output

The two most common snags after wiring up Coverlet aren't conceptual — they're operational: running the command from the wrong folder, or hitting a Coverlet package version that doesn't cooperate with the installed SDK. This section collects the fixes that consistently resolve them, continuing from [Running Coverlet and Reading Its Coverage Report](#running-coverlet-and-reading-its-coverage-report).

### Why does dotnet test run but never print a coverage table?

The single most common cause — confirmed against this very repo in [the previous section's callout](#how-do-you-run-the-coverage-command-with-dotnet-test) — is running the command from the wrong working directory. `dotnet test /p:CollectCoverage=true` has to run from inside the **test** project folder, `StringManipulation.Tests` here, not from the solution root or from the `StringManipulation` console project. If you'd rather not `cd`, point `dotnet test` straight at the test project's `.csproj` instead:

```bash
dotnet test StringManipulation.Tests/StringManipulation.Tests.csproj /p:CollectCoverage=true
```

The second most common cause is a missing or stale `coverlet.msbuild` reference (see [Which Coverlet packages do you actually need to install?](#which-coverlet-packages-do-you-actually-need-to-install)) — without it, `CollectCoverage=true` is silently ignored, exactly what this README's own callout found when testing the command against this repo's current `.csproj`. The fix: add the package, then **rebuild** with `dotnet build`. NuGet can fail to persist a new `<PackageReference>` if the `.csproj` was already open in an editor when the package was added, so closing and reopening it (or editing the XML directly, as in [Module 6 — Moq Library](#module-6--moq-library)) is worth trying too.

### Why might the pinned coverlet.console version matter?

NuGet's own "install" snippet for `coverlet.console` doesn't always resolve to a version that behaves correctly against a given SDK. Pinning an explicit version sidesteps that:

```bash
dotnet tool install --global coverlet.console --version 6.0.4
```

Since it's a **global tool** (see [How do you install Coverlet.Console as a global tool?](#how-do-you-install-coverletconsole-as-a-global-tool)), reinstalling with `--version` simply overwrites whatever version is currently registered — no project file is involved.

### Is there a way to get coverage without coverlet.msbuild at all?

Yes — `coverlet.collector`, the package this repo has had since [Module 1 — First Test](#module-1--first-test), already plugs into `dotnet test` through VSTest's own data-collector pipeline, with no need for `coverlet.msbuild` or the `/p:CollectCoverage=true` property:

```bash
dotnet test --collect:"XPlat Code Coverage"
```

This writes a `coverage.cobertura.xml` file under `StringManipulation.Tests/TestResults/<run-id>/` instead of printing a percentage table to the console. It's the standard .NET SDK approach, and it works with the packages this repo already references today — `coverlet.msbuild` is only needed for the inline console table from [Running Coverlet and Reading Its Coverage Report](#running-coverlet-and-reading-its-coverage-report).

### How do you turn the raw XML report into a readable HTML report?

The `coverage.cobertura.xml` produced by `--collect:"XPlat Code Coverage"` isn't meant to be read directly. `ReportGenerator`, installed as another global tool, turns it into a browsable HTML report:

```bash
dotnet tool install -g dotnet-reportgenerator-globaltool

dotnet reportgenerator -reports:"./TestResults/**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

Opening `coveragereport/index.html` in a browser shows coverage line by line — the same line/branch/method breakdown from [How do you interpret line, branch, and method percentages?](#how-do-you-interpret-line-branch-and-method-percentages), rendered against the actual source instead of a flat console table.

### What if the packages are installed but the percentages still don't show up?

A short checklist for the remaining edge cases reported around this lesson:

- **Mismatched Coverlet versions** — `coverlet.collector` and `coverlet.msbuild` drifting out of sync with each other can silently suppress the table; updating both to matching, current versions resolves it.
- **Stale build artifacts** — running `dotnet build` once before `dotnet test` clears up cases where the run picks up a build that predates the Coverlet package references.
- **An already-open `.csproj`** — adding a package through Visual Studio's NuGet UI while the `.csproj` is open in another editor can silently fail to save the new `<PackageReference>`; closing and reopening the file resolves it.
- **Wrong project path** — `dotnet test` defaults to the current directory; running it from the solution root, from `StringManipulation` (the console app, not the test project), or from any folder other than `StringManipulation.Tests` produces a normal test run with zero coverage output, not an error.

## Filtering Coverage with Include and ExcludeFromCodeCoverage

When you run Coverlet for the first time, the percentage it reports can be misleading — it measures code you never intended to test, like console classes or presentation-layer utilities. This lesson covers `Include`, `ExcludeByAttribute`, and `ExcludeFromCodeCoverage` — the parameters that let your report reflect only actual business logic, continuing from [Troubleshooting Coverlet Coverage Output](#troubleshooting-coverlet-coverage-output).

### Why isn't your initial coverage percentage realistic?

Running `dotnet test /p:CollectCoverage=true` makes Coverlet calculate coverage for the **entire referenced module** — every class in the project under test, with no distinction between business logic and infrastructure code.

In this repo, `StringManipulation` (see [Tech Stack](#tech-stack)) contains exactly that split:

- `StringOperations` — the business logic, the class actually exercised by `StringOperationsTest.cs` (see [Features](#features)).
- `Program` — the console menu loop from [Run the Console App](#run-the-console-app): it only prints prompts and reads `Console.ReadLine()` input. Nothing in `StringOperationsTest.cs` calls it, and nothing should — it has no business logic to validate.

`Program` shouldn't count toward coverage, because it isn't part of the behavior the test suite is meant to validate. Left unfiltered, it dilutes the percentage with code that was never a target for testing in the first place.

> **What does Coverlet measure by default?** Every class in the module referenced by the test project, with no distinction between business logic and infrastructure code — which is exactly why filtering it matters.

### How do you filter by namespace with the Include parameter?

The first technique filters from the command line, with no code changes. `Include` tells Coverlet which namespace to measure and discards everything else:

```bash
dotnet test /p:CollectCoverage=true /p:Include="[StringManipulation]StringManipulation.*"
```

Coverlet walks every class in the project and applies one rule: if the class belongs to the `StringManipulation` namespace, measure it; if it doesn't, skip it entirely. The report that comes back reflects only what you actually wanted to measure.

> 📌 The assembly filter doesn't have to name `StringManipulation` explicitly — `/p:Include="[*]StringManipulation.*"` works the same way, with `[*]` matching any assembly. The explicit form is more precise when a solution has several test-covered projects; the wildcard form is the one most commonly seen in examples, since it works regardless of how the assembly happens to be named.

> 📌 **This repo's classes split differently than the lesson's example.** `StringOperations` and `IFileReaderConnector` (see [Module 0 — Codebase](#module-0--codebase)) are declared inside `namespace StringManipulation { ... }`, so the filter above covers both. `Program.cs`, however, declares `internal class Program` with **no namespace block at all** — it sits in the global namespace, not inside `StringManipulation`. In this specific codebase, that means `Program` is already excluded from an `Include="[StringManipulation]StringManipulation.*"` filter without the filter doing any extra work; here, `Include` mostly confirms an existing boundary rather than actively carving `Program` out of a shared namespace.

### How do you exclude classes with ExcludeFromCodeCoverage?

The second option puts the decision in the code instead of the command — useful when you want to permanently flag which files should never count toward coverage.

`ExcludeFromCodeCoverage` is an attribute from `System.Diagnostics.CodeAnalysis` that Coverlet recognizes out of the box. You place it above the class or method you want excluded:

```csharp
using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
internal class Program
{
    // console code
}
```

The scope is flexible:

- **On a class** — excludes every method and property inside it.
- **On a method** — excludes only that specific function.
- **Combined** — mark the class, then leave one method without the attribute if you still want that one measured.

### How do you activate it from the command with ExcludeByAttribute?

Once classes carry the attribute, a different Coverlet parameter switches the filter on:

```bash
dotnet test /p:CollectCoverage=true /p:ExcludeByAttribute="ExcludeFromCodeCoverage"
```

This tells Coverlet: ignore everything carrying that attribute, and measure coverage for the rest.

> **When should you use Include versus ExcludeFromCodeCoverage?** Reach for `Include` when the filter is temporary, or scoped to a single command or CI run, without touching the source. Reach for `ExcludeFromCodeCoverage` when the exclusion is a permanent design decision that should travel with the code itself, regardless of who runs the command or how.

The end result looks similar to the `Include` approach, but the responsibility for it now lives in the source code rather than the command line.

### Can ExcludeFromCodeCoverage be applied to Main itself?

Yes — class-level and method-level exclusion can be combined on the same type. Applied to this repo's own `Program` (see [`StringManipulation/Program.cs`](#module-0--codebase)), both attributes would look like this:

```csharp
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using StringManipulation;

[ExcludeFromCodeCoverage]
internal class Program
{
    [ExcludeFromCodeCoverage]
    private static void Main(string[] args)
    {
        // console code
    }
}
```

The class-level attribute already excludes everything inside `Program`, including `Main` — stacking the attribute on `Main` too is redundant once the class itself carries it, and only matters if you ever remove the class-level attribute while still wanting `Main` specifically excluded.

### Does ExcludeFromCodeCoverage couple your production code to the test framework?

No. `ExcludeFromCodeCoverage` lives in `System.Diagnostics.CodeAnalysis`, part of the base class library that ships with the .NET SDK itself — not in `xunit`, `Moq`, or any `coverlet.*` package (see [Tech Stack](#tech-stack)). Referencing it from `StringManipulation/Program.cs` wouldn't pull in a test-only dependency any more than using `System.Linq` would.

> **Is there a `.gitignore`-style alternative to marking individual classes?** Yes — Coverlet also exposes an `Exclude` command-line parameter (the mirror image of `Include`) that filters out whole files or folders by path pattern, without touching the source at all. `Include`/`Exclude` and `ExcludeFromCodeCoverage` solve the same problem from two different angles: one lives in the command, the other lives in the code — see [When should you use Include versus ExcludeFromCodeCoverage?](#how-do-you-activate-it-from-the-command-with-excludebyattribute) for which one fits a given situation.

### What coverage percentage should you actually aim for?

Once the report only reflects real business logic, the next step is raising it by writing tests for every uncovered flow in your business functions.

A reasonable target sits between **80% and 90%** coverage. That range buys you real quality assurance without sliding into the trap of chasing every trivial line (see [What is unit test coverage, and what is it for?](#what-is-unit-test-coverage-and-what-is-it-for) for why 100% usually isn't a realistic goal in the first place).

The working loop is simple:

1. Write a new test for an uncovered scenario.
2. Run `dotnet test` with the coverage parameter.
3. Confirm the percentage went up, and repeat until you reach the target range.

> **What's the point of filtering coverage in Coverlet?** So the percentage reflects the real quality of your business logic, instead of being inflated or diluted by code you never intended to test in the first place.

This filtering groundwork is also what makes the next step worthwhile: a full, visual coverage report instead of a flat console table.

> 🔗 **Resource from this lesson:** [World/curso-unit-testing-csharp](https://github.com/World/curso-unit-testing-csharp) at branch `9-atributocoverlet`.

## Visual Coverage Reports with ReportGenerator and FineCodeCoverage

A console table of percentages is useful, but it can't show you *which* lines in *which* method are the gap. This lesson turns those numbers into something you can actually read: an HTML report generated with ReportGenerator, and a live view inside Visual Studio through the FineCodeCoverage extension — continuing from [Filtering Coverage with Include and ExcludeFromCodeCoverage](#filtering-coverage-with-include-and-excludefromcodecoverage).

### How do you export coverage to a standard XML file?

The first step is telling Coverlet to write its results in a format any tool can read, instead of just printing a table to the console:

```bash
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
```

Running it still prints the usual summary — tests passed, tests failed, coverage percentages — but it also drops a `coverage.cobertura.xml` file directly inside `StringManipulation.Tests/`, the test project's own folder. That's a different location than the `--collect:"XPlat Code Coverage"` route from [Is there a way to get coverage without coverlet.msbuild at all?](#is-there-a-way-to-get-coverage-without-coverletmsbuild-at-all), which nests the same kind of file under `TestResults/<run-id>/` instead — same file format, different command, different output path.

> **What does the `coverage.cobertura.xml` file contain?** Per-method detail: which lines were covered, which branches were evaluated, and a `true`/`false` flag for whether each one was actually exercised. It's the raw material any visual report — HTML or otherwise — is built from.

### Why use the Cobertura format instead of something else?

Cobertura is the most widely adopted coverage format — not just in .NET, but across other languages and most CI platforms, which tend to accept it without any extra configuration. Settling on it now means that if this project's pipeline ever moves to a cloud CI provider, the coverage step doesn't need to be regenerated or reformatted — it already speaks the format the rest of the ecosystem expects.

### How do you generate an HTML report with ReportGenerator?

The XML is complete, but reading it by hand is impractical. `ReportGenerator` converts it into a browsable report; like `coverlet.console` (see [How do you install Coverlet.Console as a global tool?](#how-do-you-install-coverletconsole-as-a-global-tool)), it's a **global .NET tool**, not a project package, installed once per machine:

```bash
dotnet tool install -g dotnet-reportgenerator-globaltool
```

Once installed, running it takes two required parameters and one optional one:

```bash
reportgenerator -reports:"coverage.cobertura.xml" -targetdir:"coverage-report" -reporttypes:Html
```

- **`-reports`** — the path to the `coverage.cobertura.xml` generated in the previous step.
- **`-targetdir`** — the folder where the report should be written, e.g. `coverage-report`; it's created automatically if it doesn't exist.
- **`-reporttypes`** — optional; the output format. `Html` is the easiest to read, though ReportGenerator also supports formats like `Badges` or `TextSummary`.

Running it produces a `coverage-report` folder with everything the report needs. Opening `coverage-report/index.html` in a browser gives you a fully navigable report.

### What information can you see in the HTML report?

The report lets you drill into every class the test run touched. For `StringOperations` (see [Features](#features)), each method shows its own coverage percentage, which lines were hit, and which scenarios were never exercised.

> 📌 **The same shape of gap exists in this repo today.** `GetStringLength` (see [Module 0 — Codebase](#module-0--codebase)) only has one test, `GetStringLength_Exception` (see [Which exceptions are worth covering with tests?](#which-exceptions-are-worth-covering-with-tests)) — it covers the `throw new ArgumentNullException()` branch, but no test ever calls `GetStringLength` with a real string to exercise the `return str.Length;` line. That's the same "happy path never tested" pattern the lesson describes, just on a method that returns an `int` instead of a `string`. `RemoveWhitespace` (see [Features](#features)) shows the more extreme version of the same gap: it's fully implemented, but since no test in `StringOperationsTest.cs` calls it at all (see [Practice challenge: testing `RemoveWhitespace`](#practice-challenge-testing-removewhitespace), still open), an HTML report run against this repo today would show it at zero coverage — not because the method is missing, but because nothing exercises it yet.

> **What's a branch in code coverage?** Every possible execution path inside a method — the arms of an `if` or a `switch`. Branch coverage measures how many of those paths your tests actually exercised, the same metric introduced in [How do you interpret line, branch, and method percentages?](#how-do-you-interpret-line-branch-and-method-percentages).

### How do you view coverage without leaving Visual Studio with FineCodeCoverage?

If opening a browser every time feels heavy, the **FineCodeCoverage** extension — already named as an option back in [What tools exist to measure coverage in .NET?](#what-tools-exist-to-measure-coverage-in-net) — surfaces the same kind of information directly inside the IDE. Install it from Visual Studio's Extensions menu, then close and reopen the editor for it to register.

You'll find it at **View > Other Windows > FineCodeCoverage**. From there you can:

- Browse every analyzed class and drill into each test's detail.
- See at a glance which classes are covered and which were left out.
- Pull up a report without running a single command manually.

> 📌 FineCodeCoverage doesn't reuse the `coverage.cobertura.xml` from the steps above — it builds its own report by running the whole project fresh, with no filters or exclusions applied by default.

### How do you configure FineCodeCoverage to exclude classes?

Open **Tools > Options** and find the FineCodeCoverage section. From there you choose which engine it runs underneath — Coverlet, OpenCover, or Microsoft's own — and apply filters by directory or by attribute.

The key option is **`ExcludeByAttribute`**: the same idea as the command-line `/p:ExcludeByAttribute="ExcludeFromCodeCoverage"` from [How do you activate it from the command with ExcludeByAttribute?](#how-do-you-activate-it-from-the-command-with-excludebyattribute), just configured once through the UI instead of typed into every command. Pointing it at `ExcludeFromCodeCoverage` keeps `Program` (or any other class already marked with it) out of the percentage here too, without repeating the command-line flag.

> **When should you use ReportGenerator versus FineCodeCoverage?** Use ReportGenerator when the report needs to travel — into a CI/CD pipeline, or shared as a portable HTML folder. Use FineCodeCoverage while actively developing, when what you need is immediate feedback inside Visual Studio rather than a file to hand off.

Between the two, this repo now has two complementary paths to the same answer: one automatable and portable, the other wired straight into the editor.

## What You Learned in This Course: From Asserts to Coverage

Finishing a .NET unit-testing course with xUnit leaves you with a concrete toolbox: structuring tests, verifying results, simulating dependencies, and measuring coverage. This closing lesson ties together everything covered across this README — from [Creating Your First Unit Test with xUnit](#creating-your-first-unit-test-with-xunit) through [Visual Coverage Reports with ReportGenerator and FineCodeCoverage](#visual-coverage-reports-with-reportgenerator-and-finecodecoverage) — and points at what to practice next.

### What did you learn about unit testing in xUnit?

The course moved through the pillars that hold up a real .NET testing strategy — not as disconnected topics, but as layers that build on each other:

- Several testing libraries available in .NET, and why xUnit is one of the most widely used in the industry (see [Unit Testing Libraries in .NET: MSTest, NUnit, and xUnit](#unit-testing-libraries-in-net-mstest-nunit-and-xunit)).
- A first test project and a first unit test, following recognized good practices (see [Creating Your First Unit Test with xUnit](#creating-your-first-unit-test-with-xunit)).
- xUnit's different assertion types, used to validate that code behaves as expected (see [Best Practices and Assert Types in xUnit](#best-practices-and-assert-types-in-xunit) and [Testing with StartsWith, Contains, and Throws](#testing-with-startswith-contains-and-throws)).
- Complex scenarios handled with the Moq library, simulating external dependencies (see [Mocking Dependencies with Moq in .NET](#mocking-dependencies-with-moq-in-net), [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c), and [Simulating Dependencies and Behavior with Mock in Unit Tests](#simulating-dependencies-and-behavior-with-mock-in-unit-tests)).
- Coverage analysis, used to spot functions and methods that were never actually tested (see [Test Coverage with Coverlet in .NET](#test-coverage-with-coverlet-in-net) through [Visual Coverage Reports with ReportGenerator and FineCodeCoverage](#visual-coverage-reports-with-reportgenerator-and-finecodecoverage)).

That sequence has a clear logic: first you understand the framework, then you write the test, then you make it robust, and finally you measure how complete it really is.

### Why do Mock and coverage matter in your tests?

Unit tests don't live in a vacuum. When your code depends on databases, external services, or components that don't exist yet, you need a way to isolate it — that's what Moq is for: simulated objects that behave like real dependencies without ever executing them (see [What is a mock, and why do you need one in your tests?](#what-is-a-mock-and-why-do-you-need-one-in-your-tests)).

> **What is the Mock library for in xUnit?** It imitates your project's dependencies, so you can test a unit of code in isolation without invoking real services.

Coverage is the thermometer. It shows you what percentage of your code is actually exercised by tests, and — more importantly — where the gaps are. Without that measurement, it's easy to believe you're testing well while critical functions sit untouched, exactly the kind of blind spot [Why isn't your initial coverage percentage realistic?](#why-isnt-your-initial-coverage-percentage-realistic) and the [`GetStringLength`/`RemoveWhitespace` gap](#what-information-can-you-see-in-the-html-report) called out earlier in this README.

> **What is coverage analysis?** The review that identifies which pieces of code — functions or methods — aren't covered by the tests you've already written.

### How do you keep practicing after the course?

The best way to make this stick is to get your hands dirty again, with two concrete exercises you can start on this repo right now:

1. **Finish the tests left pending throughout the course.** This README already tracks them: [`RemoveWhitespace`](#practice-challenge-testing-removewhitespace), [`TruncateString`](#practice-challenge-testing-truncatestring), and collapsing `IsPalindrome_True`/`IsPalindrome_False` into a single [`[Theory]`](#practice-challenge-parameterizing-ispalindrome).
2. **Create a new test project with a different library than xUnit, and replicate the same tests.** NUnit or MSTest (see [Unit Testing Libraries in .NET: MSTest, NUnit, and xUnit](#unit-testing-libraries-in-net-mstest-nunit-and-xunit)) are the natural candidates — the attribute and assertion mapping in [How do xUnit attributes translate to NUnit and MSTest?](#how-do-xunit-attributes-translate-to-nunit-and-mstest) is exactly the cheat sheet for that translation.

Comparing syntax, configuration, and ergonomics between the two isn't just about learning a second library — it's about understanding *why* you'd choose one tool over another the next time a real project calls for that decision.

### What topics might come up in a job interview?

Several of the concepts covered are interview staples for .NET developers, worth keeping fresh:

- The **AAA** structure (Arrange, Act, Assert) as the pattern for organizing tests (see [What is the AAA (Arrange-Act-Assert) structure?](#what-is-the-aaa-arrange-act-assert-structure)).
- The **FIRST** principles that define what a healthy unit test looks like (see [What are the FIRST principles of testing?](#what-are-the-first-principles-of-testing)).
- Using the **Moq** library to simulate dependencies (see [How do you use the Moq library to simulate dependencies in .NET?](#how-do-you-use-the-moq-library-to-simulate-dependencies-in-net)).
- xUnit-specific features, like its assertion methods and test attributes (see [The Fact Attribute in Depth](#the-fact-attribute-in-depth) and [Parameterized Tests with Theory and InlineData](#parameterized-tests-with-theory-and-inlinedata)).

> **What's the AAA structure in unit testing?** A pattern that organizes every test into three blocks: Arrange to set up data, Act to execute the behavior, and Assert to verify the result.

Being able to walk through these with a code example is most of the way to a strong interview answer.

### What's the next step to master testing in .NET?

What comes next is open-ended. Integration tests, test doubles beyond mocks — fakes, stubs, spies — or wiring this suite into a CI/CD pipeline are all natural extensions, and every one of them builds directly on what's already in this repo's `StringManipulation.Tests` project.

## Module Roadmap

| Module | Branch         | Topic                                   | Status        |
|:------:|----------------|------------------------------------------|:-------------:|
| 0      | `0-codebase`   | Base code — string utilities console app, no tests yet | ✅ Done |
| 1      | `1-firsttest`  | First xUnit test project — `StringManipulation.Tests` scaffolded and wired via `ProjectReference` | ✅ Done |
| 2      | `2-types-assert` | AAA convention + multi-assert tests — `Assert.NotNull`/`NotEmpty`/`Equal` and the `IsPalindrome_True`/`_False` boolean pair | ✅ Done |
| 3      | `3-types-assert2` | `StartsWith`/`Contains`/`Throws` — `QuantintyInWords` and `GetStringLength_Exception` | ✅ Done |
| 4      | `4-theory-inlinedata` | First parameterized test — `Theory`/`InlineData` on `FromRomanToNumber` | ✅ Done |
| 5      | `5-skip`       | `[Fact(Skip = "...")]` to pause a test without deleting it — `ConcatenateStrings` paused pending `TICKET-001` | ✅ Done |
| 6      | `6-moqlibrary` | First mocking dependency — `Moq 4.18.4` added to the test project; `CountOccurrences` mocks `ILogger<StringOperations>` | ✅ Done |

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
    ├── StringManipulation.Tests.csproj # net8.0, ProjectReference -> StringManipulation.csproj · M6: + Moq 4.18.4
    ├── StringOperationsTest.cs         # M1-2: Concatenate/IsPalindrome · M3: QuantintyInWords/GetStringLength_Exception · M4: FromRomanToNumber [Theory] · M5: ConcatenateStrings [Skip] · M6: CountOccurrences [Moq<ILogger<T>>]
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

### Module 4 — Theory InlineData

Branch [`4-theory-inlinedata`](https://github.com/CristianSifuentes/DotNetTestingLab/tree/4-theory-inlinedata) is a single commit, `6241051` — the largest single commit so far (148 lines: 135 in README, 13 in the test file). It introduces the suite's **first parameterized test**, `FromRomanToNumber`, using `[Theory]` + `[InlineData]` instead of `[Fact]`. No package changes are needed: `[Theory]`/`[InlineData]` ship with the `xunit` package already referenced since Module 1.

| File | Change |
|------|--------|
| `StringOperationsTest.cs` | One new method, `FromRomanToNumber(string romanNumber, int expected)`, decorated with `[Theory]` and three `[InlineData]` rows — `("V", 5)`, `("III", 3)`, `("X", 10)` — replacing what would otherwise be three near-duplicate `[Fact]` tests with a single parameterized one (see [How do you write a Theory and InlineData test step by step?](#how-do-you-write-a-theory-and-inlinedata-test-step-by-step)). It still follows AAA internally: instantiate `StringOperations`, call `FromRomanToNumber(romanNumber)`, then `Assert.Equal(expected, result)` — `FromRomanToNumber` itself just delegates to Humanizer's `input.FromRoman()` (see [Tech Stack](#tech-stack)). xUnit runs the method three times, once per `InlineData` row, and reports each as an independent pass/fail. |

**Evolutionary changes vs. Module 3:**

- **Changed** — `StringOperationsTest.cs` only (+13 lines). No `.csproj` changes: `xunit 2.4.2` already exposes `[Theory]`/`[InlineData]`, so unlike Module 1's project-creation step, this module needed zero new NuGet packages.
- **Test count** — the 5 `[Fact]` tests from Module 3 are untouched; `FromRomanToNumber` is the suite's first `[Theory]`, contributing 3 independently-reported outcomes from a single method definition (5 `[Fact]`s + 1 `[Theory]` × 3 rows + the still-unused `UnitTest1.Test1` = 9 discoverable test results from 7 methods).
- **First parameterized test in the repo** — every prior module added a new `[Fact]` or extended an existing one's assertions; this is the first method whose definition produces multiple independent test results, the core payoff described in [Why parameterize unit tests in xUnit?](#why-parameterize-unit-tests-in-xunit).
- **README sample drift** — the README's code block for this test (in [How do you write a Theory and InlineData test step by step?](#how-do-you-write-a-theory-and-inlinedata-test-step-by-step)) calls `strOperations.FromRomanToNumber(...)` without the `var strOperations = new StringOperations();` line the real committed test has. Read literally, the snippet wouldn't compile on its own — it was trimmed to keep the lesson focused on `[Theory]`/`[InlineData]`, the same kind of doc/code gap flagged for `Assert.Throws` vs. `Assert.ThrowsAny` in [Module 3](#module-3--types-assert-2).
- **Practice challenge still unimplemented** — [Practice challenge: parameterizing IsPalindrome](#practice-challenge-parameterizing-ispalindrome) asks for `IsPalindrome_True`/`IsPalindrome_False` to be collapsed into one `[Theory]`, but `StringOperationsTest.cs` still keeps them as two separate `[Fact]` tests — the same "lesson documented, test not committed" pattern seen in Modules 2 and 3 (`RemoveWhitespace`, `TruncateString`).

### Module 5 — Skip

Branch [`5-skip`](https://github.com/CristianSifuentes/DotNetTestingLab/tree/5-skip) ships **two commits that pull in different directions** — one pauses a test and documents `Skip`, the other has nothing to do with skipping at all. Diffing the branch's own base (the commit immediately before its first commit) against its tip isolates exactly what `5-skip` contributed, with nothing inherited from later merges mixed in: **133 insertions / 2 deletions in `README.md`, plus a 1-line change in `StringOperationsTest.cs`** — confirmed with `git diff --stat <base>..5-skip`, which reports exactly those two files touched in the entire repository.

| Commit | Message | What it actually did |
|--------|---------|------------------------|
| `fe6f74a` | Adding information for The Skip Attribute in xUnit | Adds the [The Skip Attribute in xUnit](#the-skip-attribute-in-xunit) lesson to the README (`+96/-2` lines) **and** the only production-code change in the branch: `ConcatenateStrings`'s `[Fact]` becomes `[Fact(Skip = "This test is not valid at this time, TICKET-001")]` in `StringOperationsTest.cs` (`+1/-1` line). |
| `44dba71` | Add How do xUnit, NUnit, and MSTest compare architecturally? and others sections | README-only (`+37/-0` lines). Adds three subsections — [How do xUnit, NUnit, and MSTest compare architecturally?](#how-do-xunit-nunit-and-mstest-compare-architecturally), [What are the architectural advantages of xUnit?](#what-are-the-architectural-advantages-of-xunit), and [What are the architectural disadvantages of xUnit?](#what-are-the-architectural-disadvantages-of-xunit) — under the **earlier** [Unit Testing Libraries in .NET](#unit-testing-libraries-in-net-mstest-nunit-and-xunit) section. None of it is about `Skip`; it backfills documentation depth into a topic two modules upstream while this branch was checked out. |

Rather than adding a new test, the commit that *is* about this module pauses an existing one: `ConcatenateStrings` (see [Module 1 — First Test](#module-1--first-test)) now carries a documented `Skip` reason instead of running on every `dotnet test`.

| File | Change |
|------|--------|
| `StringOperationsTest.cs` | `ConcatenateStrings`'s `[Fact]` becomes `[Fact(Skip = "This test is not valid at this time, TICKET-001")]` — the method body is untouched, so the test still compiles and is still discoverable, it simply doesn't execute (see [How do you apply Skip to a test step by step?](#how-do-you-apply-skip-to-a-test-step-by-step)). |

**Evolutionary changes vs. Module 4:**

- **Changed** — `StringOperationsTest.cs` only, and only on one line: the `[Fact]` attribute above `ConcatenateStrings`. No assertions, method bodies, `.csproj` files, or any other file under `StringManipulation/` were touched — verified directly against `git diff --stat 4-theory-inlinedata 5-skip`.
- **Test count unchanged, runnable count down by one** — the suite still discovers the same 7 methods (5 `[Fact]`s + 1 `[Theory]` with 3 rows, plus the unused `UnitTest1.Test1`) from Module 4 — 9 discoverable test results in total, confirmed against `StringOperationsTest.cs` at this branch's tip — but `dotnet test` now reports `ConcatenateStrings` as **skipped** rather than **passed**, the first test in the repo to carry that status.
- **First use of a named Fact parameter** — every prior `[Fact]` in the suite used the bare attribute; this is the first to pass a named argument (`Skip`), the same mechanism documented for `DisplayName` in [What are the core characteristics of Fact?](#what-are-the-core-characteristics-of-fact).
- **The branch's larger commit isn't about Skip at all** — of the 133 README lines `5-skip` adds, only 96 belong to the Skip lesson itself; the remaining 37 (`44dba71`) retroactively complete the xUnit/NUnit/MSTest architectural comparison in a section that predates this module by two branches. It's legitimate documentation work, but it means this branch's own history mixes one module's feature work with another module's retroactive polish — worth knowing before bisecting this repo's history by branch name alone.
- **Ticket reference is a placeholder** — the message points at `TICKET-001`, a stand-in rather than an entry in a real Jira/Azure DevOps project, since this repo doesn't run one. The convention is what the lesson cares about — see [Why should you create a backlog ticket when you skip a test?](#why-should-you-create-a-backlog-ticket-when-you-skip-a-test) — the specific tracker is an implementation detail for a real project.
- **Open item carried forward** — `ConcatenateStrings` was already flagged for its missing `// Arrange` comment back in [Module 2](#module-2--types-assert); that inconsistency is still present and now sits alongside the new `Skip` reason, untouched by this module.

### Module 6 — Moq Library

Branch [`6-moqlibrary`](https://github.com/CristianSifuentes/DotNetTestingLab/tree/6-moqlibrary) introduces the suite's **first mocking dependency**, Moq, across three commits and two lessons. Measured against the branch's own base (`f23f4bb`, the commit immediately before its first) with `git diff --stat f23f4bb 6-moqlibrary`, the branch's tip carries **182 insertions / 2 deletions in `README.md`**, plus **14 lines added** across `StringManipulation.Tests.csproj` (+1) and `StringOperationsTest.cs` (+13) — no file under `StringManipulation/` (the production project) changes at all.

| Commit | Message | What it actually did |
|--------|---------|------------------------|
| `3d5bcc1` | Add new information for Mocking Dependencies with Moq in .NET | README only (+69/-0). Documents what a mock is, why testing with real dependencies breaks test isolation, and how Moq fits into testing a service's Entity Framework/logging dependencies (see [Mocking Dependencies with Moq in .NET](#mocking-dependencies-with-moq-in-net)). |
| `13e293d` | Add code and new information for Moq - 4.18.4 | Code only (+14/-0). Adds `<PackageReference Include="Moq" Version="4.18.4" />` to `StringManipulation.Tests.csproj` and a new `[Fact]`, `CountOccurrences`, that mocks `ILogger<StringOperations>` with `new Mock<ILogger<StringOperations>>()` and passes `mockLogger.Object` into `StringOperations`'s logging constructor (see [How do you mock a dependency with Moq step by step?](#how-do-you-mock-a-dependency-with-moq-step-by-step)). |
| `a3d7028` | Add new section Mocking ILogger with Moq in C# | README only (+113/-2). Adds the [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c) lesson — the `NullReferenceException` you'd hit debugging `CountOccurrences` without a mock, walked through with the Visual Studio debugger — plus this module's row in [Module Roadmap](#module-roadmap) and this very subsection. Unlike the first two, it isn't a first-parent commit on `6-moqlibrary`; see the Git-topology note below. |

| File | Change |
|------|--------|
| `StringManipulation.Tests.csproj` | Gains one line: a `Moq 4.18.4` package reference, added alongside the existing `Microsoft.NET.Test.Sdk`, `xunit`, `xunit.runner.visualstudio`, and `coverlet.collector` references. |
| `StringOperationsTest.cs` | Two new `using` directives — `Moq` and `Microsoft.Extensions.Logging` — and one new `[Fact]`, `CountOccurrences`, that arranges a `Mock<ILogger<StringOperations>>`, constructs `StringOperations` with `mockLogger.Object`, calls `CountOccurrences("Hello platzi", 'l')`, and asserts the result equals `3`. |

**Evolutionary changes vs. Module 5:**

- **Added** — the `Moq` package reference and the `CountOccurrences` test (+14 lines across both files). No other file under `StringManipulation.Tests/` or `StringManipulation/` changed.
- **Test count** — Module 5's tip discovers **9** test results from **7** methods (5 `[Fact]`s + 1 `[Theory]` with 3 `[InlineData]` rows + the unused `UnitTest1.Test1`); Module 6 adds one `[Fact]` method, bringing the tip to **10** discoverable results from **8** methods (6 `[Fact]`s + the same 3-row `[Theory]` + `UnitTest1.Test1`) — confirmed by reading `StringOperationsTest.cs` at `645d2c8`, the branch's own tip.
- **First mocked dependency in the suite** — every prior test exercised `StringOperations` through its parameterless constructor; `CountOccurrences` is the first to use the constructor overload that takes `ILogger<StringOperations>`, and the first to inject a test double instead of a real (or absent) dependency (see [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c)).
- **`StringOperations` itself is untouched** — the `ILogger<StringOperations>` constructor overload and the `_logger.LogInformation` call inside `CountOccurrences` already existed in the production code before this module; the module's actual work was entirely on the test side (see [Why does a unit test fail when it has external dependencies?](#why-does-a-unit-test-fail-when-it-has-external-dependencies)).
- **Documentation outweighs code 13 to 1** — 182 README lines against 14 lines of `.csproj`/test code. That's a heavier lesson-to-implementation ratio than [Module 4](#module-4--theory-inlinedata)'s ~10:1 (135 README / 13 test lines), though still well short of [Module 5](#module-5--skip)'s 133:1 (133 README lines to land a single `Skip` argument). Most of Module 6's text serves the second lesson, [Mocking ILogger with Moq in C#](#mocking-ilogger-with-moq-in-c) — a debugging narrative, not just a concept primer.
- **A commit that documents the branch isn't "on" the branch** — `a3d7028` has a single parent, `0acb951` (`Merge branch '6-moqlibrary' into develop`), which means it was committed straight onto `develop` right after that merge, not onto `6-moqlibrary` itself. It only becomes reachable from `6-moqlibrary` because the next commit on the feature branch, `645d2c8` (`Merge branch 'develop' into 6-moqlibrary`), merges `develop` back in and picks it up. The following `6848b37` (`Merge branch '6-moqlibrary' into develop`) then folds that same content into `develop` a second time — verified empty with `git diff 6848b37^1 6848b37`, since everything `645d2c8` carries was already reachable from `develop` through `a3d7028`. Net effect: two merge commits, zero net diff — a round-trip bubble in the graph, the same "history isn't a reliable map of content" theme called out more severely for `6-coverlet-attribute` below.

#### Branch continuation: `6-coverlet-attribute`

`6-coverlet-attribute` doesn't branch from a new numbered predecessor — it branches directly from `6-moqlibrary`'s own tip (`645d2c8`, confirmed with `git merge-base --is-ancestor 6-moqlibrary 6-coverlet-attribute`), making it a continuation of this module rather than a new one. The net effect, measured against that tip with `git diff --stat 6-moqlibrary 6-coverlet-attribute`, touches four files: `README.md` (`+553/-0`), `StringManipulation.Tests/StringManipulation.Tests.csproj` (`+6/-1`), `StringManipulation/Program.cs` (`+2/-0`), and `StringManipulation.Tests/StringOperationsTest.cs` (`+12/-0`).

| Commit | Message | What its diff actually contains |
|--------|---------|------------------------|
| `499e33a` | Add new information | README only (+6). Just the Table of Contents entries for [Simulating Dependencies and Behavior with Mock in Unit Tests](#simulating-dependencies-and-behavior-with-mock-in-unit-tests) — the section body itself lands in the *next* commit. |
| `6573a96` | Add new information for Test Coverage with Coverlet in .NET | README only (+143). Bundles **two** sections under one name: the full [Simulating Dependencies and Behavior with Mock in Unit Tests](#simulating-dependencies-and-behavior-with-mock-in-unit-tests) body *and* [Test Coverage with Coverlet in .NET](#test-coverage-with-coverlet-in-net) — the commit message only names the second. |
| `9dd9072` | Add new information for Running Coverlet and Reading Its Coverage Report | README only (+87). Matches its message exactly: adds [Running Coverlet and Reading Its Coverage Report](#running-coverlet-and-reading-its-coverage-report). |
| `0aee17e` | Add new information for Troubleshooting Coverlet Coverage Output | README only (+61). Matches its message exactly: adds [Troubleshooting Coverlet Coverage Output](#troubleshooting-coverlet-coverage-output). |
| `0750dd4` | Add new Filtering Coverage with Include and ExcludeFromCodeCoverage | **Code only — zero README lines**, despite the message. Adds `coverlet.msbuild 3.2.0` to `StringManipulation.Tests.csproj` (+5/-1) and a new `ReadFile` `[Fact]` test to `StringOperationsTest.cs` (+12). The section named in the message actually ships in the *next* commit. |
| `92b8699` | Add new info for System.Diagnostics.CodeAnalysis | README (+121) **and** code (+2). The README hunk is the full [Filtering Coverage with Include and ExcludeFromCodeCoverage](#filtering-coverage-with-include-and-excludefromcodecoverage) section — the one `0750dd4`'s message promised. The code hunk adds `using System.Diagnostics.CodeAnalysis;` and `[ExcludeFromCodeCoverage]` to `StringManipulation/Program.cs`, which *is* what this commit's own message refers to. |
| `65e3fe7` | Add new info for Visual Coverage Reports with ReportGenerator and FineCodeCoverage | README only (+135). Bundles **two** sections again: [Visual Coverage Reports with ReportGenerator and FineCodeCoverage](#visual-coverage-reports-with-reportgenerator-and-finecodecoverage) *and* [What You Learned in This Course: From Asserts to Coverage](#what-you-learned-in-this-course-from-asserts-to-coverage) — only the first is named. |

> 📌 **The commit messages on this branch are an unreliable map of their own diffs.** Three of the seven (`6573a96`, `0750dd4`, `65e3fe7`) either bundle a section the message never names, or — in `0750dd4`'s case — contain none of the README content the message describes at all, while still carrying real, unannounced code changes. The five merge commits interleaved with these (`Merge branch 'develop'`, `Merge branch 'main' into develop`, `Merge branch '6-moqlibrary' into develop`) carry no unique content of their own; they only fold `develop` back in. This is the same kind of branch-history quirk flagged for `5-skip` in [Module 5 — Skip](#module-5--skip) — one commit there did unrelated work under an unrelated name — except here it happens repeatedly, and it mixes in actual production code rather than just README depth.

| File | Change |
|------|--------|
| `StringManipulation.Tests.csproj` | Adds `<PackageReference Include="coverlet.msbuild" Version="3.2.0" />` and bumps the existing `coverlet.collector` reference from `3.1.2` to `3.2.0` to match it — closing the exact gap called out repeatedly in [How do you install and use Coverlet in your project?](#how-do-you-install-and-use-coverlet-in-your-project) ("`coverlet.msbuild`... isn't referenced yet"). With both packages now present and version-matched, `dotnet test /p:CollectCoverage=true` should print the console coverage table this README's Coverlet sections describe — assuming the project still builds (see below). |
| `StringManipulation/Program.cs` | Gains `using System.Diagnostics.CodeAnalysis;` and an `[ExcludeFromCodeCoverage]` attribute on `internal class Program` — the exact code-level recommendation from [How do you exclude classes with ExcludeFromCodeCoverage?](#how-do-you-exclude-classes-with-excludefromcodecoverage), now actually applied instead of just demonstrated in a snippet. |
| `StringOperationsTest.cs` | Adds a new `[Fact]`, `ReadFile`, implementing the `Setup`/`Returns`/`It.IsAny<T>()` pattern from [Simulating Dependencies and Behavior with Mock in Unit Tests](#simulating-dependencies-and-behavior-with-mock-in-unit-tests): `new Mock<IFileReaderConector>()`, `.Setup(p => p.ReadString(It.IsAny<string>())).Returns("Reading file")`, then asserts `strOperations.ReadFile(mockFileReader.Object, "file2.txt")` equals `"Reading file"`. |

**Evolutionary changes vs. Module 6's original tip (`6-moqlibrary`):**

- **Coverage tooling matured from documented to installed** — `coverlet.msbuild` moves from "a gap this README calls out" to an actual `<PackageReference>`, and `coverlet.collector` gets bumped alongside it so the two packages stay version-matched (`3.2.0`/`3.2.0`) — exactly the failure mode this README's own [Troubleshooting Coverlet Coverage Output](#troubleshooting-coverlet-coverage-output) warns about under "Mismatched Coverlet versions."
- **Filtering moved from lesson to code** — `Program` now actually carries `[ExcludeFromCodeCoverage]`, turning [Filtering Coverage with Include and ExcludeFromCodeCoverage](#filtering-coverage-with-include-and-excludefromcodecoverage)'s main recommendation into a real, committed change rather than a documented possibility.
- **A new test landed with a build-breaking typo** — `ReadFile`'s `Mock<IFileReaderConector>` misspells the real interface, `IFileReaderConnector` (see [Module 0 — Codebase](#module-0--codebase)), missing the `n` in `Connector`. This is a `CS0246` compile error, not a runtime failure — it currently breaks the entire `StringManipulation.Tests` build, so **no test in the project can run** until it's fixed, including the otherwise-unrelated `CountOccurrences` and `FromRomanToNumber` tests from earlier modules.
- **Test inventory grew by one method, but can't be counted yet** — before this branch, `StringOperationsTest.cs` held 7 methods (6 `[Fact]`s including the skipped `ConcatenateStrings`, plus 1 `[Theory]` with 3 rows); `ReadFile` would make it 8 in that file (9 total with `UnitTest1.Test1`, 11 discoverable results once the `[Theory]` rows are counted individually) — but until the typo is fixed, `dotnet test` reports a build failure for the whole assembly instead of a pass/fail/skip breakdown for any of them.
- **Net README growth dwarfs every prior module** — `+553` lines is more than `6-moqlibrary`'s own total README contribution (`182` lines, across `3d5bcc1`, `13e293d`, and `a3d7028`) plus [Module 4](#module-4--theory-inlinedata)'s (`135` lines) combined, reflecting that this continuation carries five full lesson sections (Mock `Setup`/`Returns`/`It.IsAny`, two Coverlet fundamentals lessons, a troubleshooting FAQ, and coverage filtering) plus the course's closing wrap-up lesson, rather than one focused topic per branch like every earlier module.

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
- [Moq](https://github.com/devlooped/moq) `4.18.4` — mocking framework for test doubles, introduced in Module 6
- [Coverlet](https://github.com/coverlet-coverage/coverlet) `3.1.2` (`coverlet.collector`) — cross-platform code coverage, bundled since Module 1; see [Test Coverage with Coverlet in .NET](#test-coverage-with-coverlet-in-net)

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
