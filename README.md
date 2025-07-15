---
### Overview

This project repository contains all the essential **C# console application concepts** covered in **Phase 1** of the .NET Full Stack Developer training program. It includes beginner to intermediate-level C# features such as input/output, data types, control structures, object-oriented programming, namespaces, and exception handling.

---

### Technologies Used

* **.NET SDK** (.NET 6 or higher recommended)
* **C#**
* **Visual Studio Code** or any C#-supported IDE

---

## Folder Structure

```
/dot_Net_fullstack/
│
├── Program.cs                  // Main program entry
├── datatype.cs                // Data type and type-checking
├── Operator.cs                // Operators with examples
├── conditionalStmt.cs         // if-else, switch-case
├── loops.cs                   // for, while, do-while
├── ExceptionHandling.cs       // Basic and advanced exception handling
├── CompanyA/User.cs           // Namespace: CompanyA
├── CompanyB/User.cs           // Namespace: CompanyB
├── University/Person.cs       // Base OOP class
├── University/Stu.cs          // Derived OOP class with interface
└── README.md                  // Documentation
```

---

## How to Run Locally

1. **Install .NET SDK** ([https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download))
2. Open terminal and navigate to the project folder

```bash
dotnet new console -n HelloCSharp
cd HelloCSharp
```

3. Replace the auto-generated `Program.cs` with your updated `Program.cs`.

4. Add your additional class files (`datatype.cs`, `Operator.cs`, etc.) to the same directory.

5. Run the project

```bash
dotnet run
```

---

## Concepts Covered

### 1. Console Input & Output

* `Console.ReadLine()` for input
* `Convert.ToInt32()`, `Convert.ToDouble()`
* `TryParse()` for safe conversions

### 2. Data Types and Type Checking

* Basic types: `int`, `float`, `double`, `string`, `bool`, `char`
* `typeof()` and `GetType()` methods

### 3. Operators

* Arithmetic, relational, logical, assignment, bitwise operators
* Examples in a dedicated file

### 4. Conditional Statements

* `if`, `else if`, `else`
* `switch-case`

### 5. Loops

* `for`, `while`, `do-while`, and `foreach`

### 6. ASCII Values

* Print character to ASCII using `(int)`
* Convert ASCII to char using `(char)`

### 7. Namespaces and Aliasing

* Creating and using custom namespaces
* Resolving naming conflicts using `using Alias = Namespace`

### 8. Object-Oriented Programming

* Classes and Objects
* Constructors
* Inheritance (`Student : Person`)
* Polymorphism (`virtual`, `override`)
* Interfaces and Implementation

### 9. Exception Handling

* `try`, `catch`, `finally`
* Specific exceptions: `DivideByZeroException`, `FormatException`, `NullReferenceException`
* Creating and throwing custom exceptions
* Using multiple `catch` blocks

---

## Sample Output

```
Enter your name: Rohit
Enter your age: 21
Enter your GPA: 8.5

Name: Rohit
Age: 21
GPA: 8.5

Character: A, ASCII: 65
...
Character: Z, ASCII: 90

ASCII 65 corresponds to character: A
```

---

## Upcoming (Phase 2 Topics)

* C# Collections (List, Dictionary, Stack, Queue)
* File I/O in C#
* LINQ
* Entity Framework (EF Core)
* ADO.NET
* Web API with ASP.NET Core

