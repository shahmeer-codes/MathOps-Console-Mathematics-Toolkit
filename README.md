# MathOps

**MathOps** is a modular, console-based mathematical computation toolkit built with **C# and .NET 8**. It provides a unified interface for performing arithmetic, numerical, scientific, trigonometric, and logarithmic calculations.

The project is designed around a separation between the **application interface** and the **mathematical operation layer**, making the codebase easier to maintain, extend, and evolve into a more advanced mathematical engine.

---

## Overview

MathOps brings multiple categories of mathematical operations into a single command-line application.

Instead of implementing every calculation directly inside the application flow, mathematical functionality is organized into a dedicated operation layer. This allows new calculations and mathematical capabilities to be added without unnecessarily complicating the main program.

The current version focuses on building a strong foundation in **C# programming, mathematical computation, code organization, and reusable methods**.

---

## Core Capabilities

### Arithmetic Operations

Perform fundamental numerical calculations:

* Addition
* Subtraction
* Multiplication
* Division
* Remainder

### Numerical Operations

Work with numerical values using common mathematical transformations:

* Absolute value
* Minimum value
* Maximum value
* Power calculation
* Square root
* Rounding
* Ceiling
* Floor

### Trigonometric Operations

Perform trigonometric calculations using degree-based input:

* Sine
* Cosine
* Tangent

### Logarithmic Operations

Support common logarithmic calculations:

* Natural logarithm
* Base-10 logarithm

---

## Architecture

MathOps follows a simple separation-of-responsibilities approach.

```text
User
  │
  ▼
Program.cs
  │
  │ User Interface & Application Flow
  ▼
MathOperations.cs
  │
  │ Mathematical Computation
  ▼
System.Math
```

### `Program.cs`

Responsible for:

* Application entry point
* Console interface
* Main navigation menu
* User interaction
* Operation selection
* Program flow
* Input handling

### `MathOperations.cs`

Responsible for:

* Mathematical calculations
* Reusable operation methods
* Interaction with the .NET `System.Math` library

Keeping these responsibilities separate makes the application easier to understand and provides a foundation for further expansion.

---

## Project Structure

```text
MathOps/
│
├── src/
│   ├── Program.cs
│   └── MathOperations.cs
│
├── README.md
├── MathOps.csproj
├── .gitignore
└── LICENSE
```

| File                | Responsibility                      |
| ------------------- | ----------------------------------- |
| `Program.cs`        | User interface and application flow |
| `MathOperations.cs` | Mathematical operation layer        |
| `MathOps.csproj`    | .NET project configuration          |
| `README.md`         | Project documentation               |
| `.gitignore`        | Git exclusion rules                 |
| `LICENSE`           | Project licensing                   |

---

## Technology Stack

* **Language:** C#
* **Framework:** .NET 8
* **Application Type:** Console Application
* **Mathematical Library:** `System.Math`
* **Development Concepts:** OOP fundamentals, modular design, methods, control flow, validation

---

## Mathematical Operation Matrix

| Category     | Operations                                                 |
| ------------ | ---------------------------------------------------------- |
| Arithmetic   | Addition, Subtraction, Multiplication, Division, Remainder |
| Numerical    | Square Root, Power, Absolute Value                         |
| Comparison   | Minimum, Maximum                                           |
| Rounding     | Round, Ceiling, Floor                                      |
| Trigonometry | Sine, Cosine, Tangent                                      |
| Logarithms   | Natural Logarithm, Base-10 Logarithm                       |

---

## Application Flow

MathOps uses an interactive menu that allows users to select a mathematical domain and perform the required calculation.

```text
┌───────────────────────────────────────┐
│              MathOps                  │
│       Mathematics Toolkit             │
├───────────────────────────────────────┤
│  1. Basic Arithmetic                  │
│  2. Square Root                       │
│  3. Minimum / Maximum                 │
│  4. Power                             │
│  5. Absolute Value                    │
│  6. Remainder                         │
│  7. Rounding                          │
│  8. Ceiling                           │
│  9. Floor                             │
│ 10. Trigonometry                      │
│ 11. Logarithm                         │
│ 12. Exit                              │
└───────────────────────────────────────┘
```

The application remains active through a `do-while` control loop, allowing multiple calculations to be performed during a single session.

---

## Input & Validation

The application includes basic safeguards for invalid operations and mathematically undefined cases.

Examples include:

* Invalid menu selections
* Invalid operation selections
* Division by zero
* Remainder with zero
* Square root of negative real numbers
* Logarithms of non-positive numbers

---

## C# Concepts Demonstrated

MathOps serves as a practical implementation of several core C# concepts:

* Variables
* Primitive data types
* Console input and output
* Type conversion
* `if` / `else` statements
* `switch` statements
* `do-while` loops
* Static classes
* Static methods
* Method parameters and return values
* Encapsulation of mathematical operations
* Namespaces
* The `System.Math` API
* Basic input validation
* Separation of responsibilities

---

## Getting Started

### Prerequisites

Install the **.NET 8 SDK** or a compatible .NET SDK.

### Clone

```bash
git clone https://github.com/your-username/MathOps-Console-Mathematics-Toolkit
```

### Navigate

```bash
cd MathOps
```

### Run

```bash
dotnet run
```

---

## Future Development

MathOps is structured so that its capabilities can be expanded beyond the current mathematical operations.

Potential future development includes:

* Advanced scientific functions
* Factorial and combinatorics
* Percentage calculations
* Greatest Common Divisor and Least Common Multiple
* Prime number analysis
* Statistical calculations
* Equation solving
* Matrix operations
* Unit conversion
* Calculation history
* More robust exception handling
* Automated unit testing
* Dedicated operation categories
* Improved console presentation
* Configuration and application settings
* Conversion into a reusable mathematical library
* Graphical or web-based interface

---

## Project Goals

The primary goal of MathOps is to build a practical C# application while progressively applying better software-engineering practices.

The project provides a foundation for learning how a simple mathematical application can evolve from a basic console program into a more structured and extensible software system.

---

## License

This project is licensed under the **MIT License**.
