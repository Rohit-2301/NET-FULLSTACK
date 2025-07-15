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
├── Program.cs                   // Main program entry with switch-based menu
├── datatype.cs                 // Demonstrates C# primitive data types
├── Operator.cs                 // Arithmetic, relational, logical operators
├── conditionalStmt.cs          // if-else, switch-case decision making
├── loops.cs                    // for, while, do-while, and nested loops
├── ExceptionHandling.cs        // Basic & advanced exception handling (try/catch/finally)
├── CompanyA/User.cs            // User class under CompanyA namespace
├── CompanyB/User.cs            // User class under CompanyB namespace
├── University/Person.cs        // OOP base class representing a person
├── University/Stu.cs           // Inherits Person, implements graduation logic
├── Collection/Collections.cs   // Interactive demo of C# collection types
└── README.md                   // Project documentation

````

---

## 📦 Module Descriptions

| Module               | Description                                                                 |
|----------------------|-----------------------------------------------------------------------------|
| **Program.cs**        | Entry point of the application with a switch-case menu to explore modules. |
| **datatype.cs**       | Covers value types like int, float, char, string, and type conversion.     |
| **Operator.cs**       | Demonstrates various operators (arithmetic, comparison, logical).          |
| **conditionalStmt.cs**| Uses `if-else` and `switch` to control program flow based on conditions.   |
| **loops.cs**          | Implements `for`, `while`, `do-while`, and nested loops with examples.     |
| **ExceptionHandling.cs** | Shows how to handle runtime errors using `try`, `catch`, and `finally`. |
| **CompanyA/User.cs**  | Simulates a user class under `CompanyA` namespace for namespace demo.      |
| **CompanyB/User.cs**  | Another user class under a different namespace (`CompanyB`).               |
| **University/Person.cs** | Base class with properties like name and age, used in OOP examples.     |
| **University/Stu.cs** | Inherits `Person` and adds GPA & graduation method (implements interface). |
| **Collection/Collections.cs** | Interactive menu to explore major C# collection types (see below).  |

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

💡 You can call the menu using:
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
* Flow control using conditionals and loops
* Object-Oriented Programming (Inheritance, Interfaces)
* Namespaces and code modularity
* Exception handling
* Working with common C# collections
* Structuring C# console projects in real-world format

---

