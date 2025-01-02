# Quadratic Equation Solver

This is a simple academic project demonstrating how to solve quadratic equations in the form:

\[
a \times x^2 + b \times x + c = 0
\]

It consists of:
- A **library** that provides the logic to compute the number of real roots and their values,
- A **test project** using **xUnit** to verify correctness,
- A **console application** that allows the user to input the coefficients (\(a\), \(b\), \(c\)) and see the results.

## Purpose

- **Academic demonstration**: This repository serves as a straightforward assignment for university courses to show how to write unit tests

## Projects

1. **QuadraticSolver** (library):  
   - Contains the class `QuadraticEquation` with a method `Solve(double a, double b, double c)`.  
   - Returns the number of roots and their values.

2. **QuadraticSolver.Tests** (xUnit test project):  
   - Verifies scenarios: no real roots (negative discriminant), one real root (zero discriminant), and two real roots (positive discriminant).  
   - Demonstrates different `Assert` methods in xUnit.

3. **QuadraticSolver.ConsoleApp** (console application):  
   - Prompts the user for the values of \(a\), \(b\), \(c\),  
   - Calls the `Solve` method from the library,  
   - Prints the results (number of roots and the roots themselves).

## How to Build and Run

1. **Clone** this repository to your local machine.
2. Open the solution in **JetBrains Rider** (or any .NET IDE that supports .NET projects).
3. (Optional) **Restore NuGet packages** if needed.
4. Build the entire solution.  
   - The library (`QuadraticSolver`) and test project (`QuadraticSolver.Tests`) should build without issues.
5. **Run the tests** (in Rider, you can use the **Tests** tool window).
6. **Set** `QuadraticSolver.ConsoleApp` as the startup project.
7. Run the console application.  
   - It will prompt for three coefficients: \(a\), \(b\), \(c\).  
   - The program will compute the roots and print the results.

## Contact

For any questions, please contact me through GitHub.
