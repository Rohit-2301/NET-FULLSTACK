---
```markdown
# .NET Full Stack Developer - Phase 1 Projects (C# Console Applications)

---

### 🧾 Overview

This repository includes all foundational **C# console application concepts** covered in **Phase 1** of the .NET Full Stack Developer training program. It focuses on **beginner to intermediate-level** C# features and prepares learners for backend development using .NET.

---

### 🛠️ Technologies Used

- **.NET SDK** (.NET 6 or higher)
- **C#**
- **Visual Studio Code**, **Visual Studio**, or any C#-supported IDE
- **Command Line / Terminal**

---

## 📁 Folder Structure

```

/dot\_Net\_fullstack/
│
├── Program.cs                 // Main program entry with switch-based menu
├── datatype.cs               // Demonstrates C# primitive data types
├── Operator.cs               // Arithmetic, relational, logical operators
├── conditionalStmt.cs        // if-else, switch-case decision making
├── loops.cs                  // for, while, do-while, and nested loops
├── ExceptionHandling.cs      // Basic & advanced exception handling (try/catch/finally)
├── CompanyA/User.cs          // User class under CompanyA namespace
├── CompanyB/User.cs          // User class under CompanyB namespace
├── University/Person.cs      // OOP base class representing a person
├── University/Stu.cs         // Inherits Person, implements graduation logic
├── Collection/Collections.cs // Interactive demo of C# collection types
└── README.md                 // Project documentation

````

---

## 📦 Module Descriptions

| Module                   | Description                                                                 |
|--------------------------|-----------------------------------------------------------------------------|
| **Program.cs**           | Entry point of the application with a switch-case menu to explore modules. |
| **datatype.cs**          | Covers value types like int, float, char, string, and type conversion.     |
| **Operator.cs**          | Demonstrates arithmetic, relational, and logical operations.               |
| **conditionalStmt.cs**   | Implements `if`, `if-else`, and `switch` statements.                       |
| **loops.cs**             | Shows looping with `for`, `while`, `do-while`, and nested examples.        |
| **ExceptionHandling.cs** | Demonstrates exception handling using `try`, `catch`, and `finally`.       |
| **CompanyA/User.cs**     | Contains a simple class inside the `CompanyA` namespace.                   |
| **CompanyB/User.cs**     | Similar class in a different namespace (`CompanyB`).                       |
| **University/Person.cs** | Base class with properties and display method for OOP demo.                |
| **University/Stu.cs**    | Derived class inheriting from `Person` and implementing an interface.      |
| **Collections.cs**       | Switch-based interactive collection demos like `List<T>`, `Queue<T>`, etc. |

---

## 📚 Collections Module Details

| Sr. | Collection Type           | Description                                     |
| --- | ------------------------- | ----------------------------------------------- |
| 1   | `ArrayList`               | Non-generic dynamic list (mixed types allowed)  |
| 2   | `List<T>`                 | Type-safe, dynamic list                         |
| 3   | `Dictionary<TKey,TValue>` | Key-value store, fast lookup by key             |
| 4   | `Stack<T>`                | LIFO data structure                             |
| 5   | `Queue<T>`                | FIFO data structure                             |
| 6   | `HashSet<T>`              | Unique unordered elements                       |
| 7   | `Switch Menu`             | User-interactive menu to explore each type      |

💡 Call the menu in your main file using:

```csharp
Collection.Collections.choice();
````

---

## ▶️ How to Run Locally

### ✅ Prerequisites

* [.NET SDK](https://dotnet.microsoft.com/en-us/download) (Version 6.0 or later)

### 🧪 Steps

```bash
cd path/to/dot_Net_fullstack/
dotnet run
```

---

## 🎯 Learning Outcome

By the end of this phase, you’ll confidently understand and apply:

* Input/Output operations
* Data types and operators
* Control flow using conditionals and loops
* Object-Oriented Programming (inheritance, interfaces)
* Namespaces and modular programming
* Exception handling
* Working with C# collections
* Organizing multi-file console applications

---
