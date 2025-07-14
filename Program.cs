using System;

// Aliases for external namespaces
using A = CompanyA;
using B = CompanyB;
using U = University;
using E = ExceptionDemo;

class Program
{
    static void Main(string[] args)
    {
        // ===================================
        // 🔹 USER INPUT
        // ===================================
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your GPA: ");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nName: {name}\nAge: {age}\nGPA: {gpa}");

        // ===================================
        // 🔹 ASCII VALUES
        // ===================================
        Console.WriteLine("\nUppercase Alphabets and their ASCII values:");
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Console.WriteLine($"Character: {c}, ASCII: {(int)c}");
        }

        // Convert ASCII to character
        int ascii = 65;
        char character = (char)ascii;
        Console.WriteLine($"\nASCII {ascii} corresponds to character: {character}");

        // ===================================
        // 🔹 BASIC C# CONCEPTS
        // ===================================
        Console.WriteLine("\nBasic Data Type, Operators, Conditionals and Loops Output:");
        datatype.show();
        Operator.show();
        conditionalStmt.show();
        loops.show();

        // ===================================
        // 🔹 NAMESPACES & ALIASING
        // ===================================
        Console.WriteLine("\nNamespace Usage with Aliases:");
        A.User userA = new A.User(); // CompanyA
        userA.display();

        B.User userB = new B.User(); // CompanyB
        userB.display();

        // ===================================
        // 🔹 OOP Concepts: Class, Inheritance, Interface
        // ===================================
        Console.WriteLine("\nOOP Concepts:");
        U.Person personA = new U.Person("Rohit", 20);
        personA.display();

        U.Stu student1 = new U.Stu("Rohit", 20, 88);
        student1.display();
        student1.graduate();

        // ===================================
        // 🔹 EXCEPTION HANDLING
        // ===================================
        Console.WriteLine("\nRunning basic division exception demo:\n");
        E.ExceptionHandling.Excephan();

        Console.WriteLine("\n=============================\n");

        Console.WriteLine("Running complete exception handling demo:\n");
        E.ExceptionHandling.CompleteExceptionDemo();

        Console.ResetColor(); // Reset console color to default
    }
}
