# MathOps

A console-based mathematics toolkit built with C# and .NET.

MathOps provides a collection of common mathematical operations through a simple interactive command-line interface.

## Features

* Basic arithmetic

  * Addition
  * Subtraction
  * Multiplication
  * Division
* Square root
* Minimum and maximum
* Power calculation
* Absolute value
* Remainder calculation
* Number rounding
* Ceiling
* Floor
* Trigonometric calculations

  * Sine
  * Cosine
  * Tangent
* Logarithmic calculations

  * Natural logarithm
  * Base-10 logarithm
* Interactive menu
* Continuous operation using a `do-while` loop
* Input validation
* Division-by-zero protection
* Separated application flow and mathematical operations

## Technologies

* C#
* .NET 8
* Console Application
* `System.Math`

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

### Source Files

**Program.cs**

Handles the application entry point, console interface, menus, user input, and program flow.

**MathOperations.cs**

Contains the mathematical operation methods used by the application.

## Getting Started

### Prerequisites

Make sure you have the .NET 8 SDK installed on your system.

### Clone the Repository

```bash
git clone https://github.com/your-username/MathOps.git
```

### Navigate to the Project

```bash
cd MathOps
```

### Run the Application

```bash
dotnet run
```

## Available Operations

| Operation         | Description                                         |
| ----------------- | --------------------------------------------------- |
| Basic Arithmetic  | Addition, subtraction, multiplication, and division |
| Square Root       | Calculates the square root of a number              |
| Minimum / Maximum | Finds the smaller or larger of two numbers          |
| Power             | Raises a number to a given exponent                 |
| Absolute Value    | Returns the absolute value of a number              |
| Remainder         | Calculates the remainder between two numbers        |
| Rounding          | Rounds a number to specified decimal places         |
| Ceiling           | Rounds a number upward                              |
| Floor             | Rounds a number downward                            |
| Trigonometry      | Calculates sine, cosine, and tangent                |
| Logarithm         | Calculates natural and base-10 logarithms           |

## Example

```text
<--- MathOps: Mathematics Toolkit --->

1). Basic Arithmetic
2). Square Root
3). Minimum / Maximum
4). Power
5). Absolute Value
6). Remainder
7). Rounding
8). Ceiling
9). Floor
10). Trigonometry
11). Logarithm
12). Exit

Enter your choice:
```

## Concepts Practiced

This project was created to practice fundamental C# and programming concepts, including:

* Variables and data types
* User input
* Type conversion
* Conditional statements
* Switch statements
* `do-while` loops
* Static classes and methods
* Method calls
* The `Math` class
* Input validation
* Exception-safe operation handling
* Console application design
* Basic code organization

## Future Improvements

Possible improvements for future versions include:

* Better input validation
* Exception handling for invalid numeric input
* Additional mathematical operations
* Calculation history
* More advanced scientific functions
* Unit testing
* Improved console interface

## License

This project is licensed under the MIT License.
