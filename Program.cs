using System;

// Aliases for external namespaces
using A = CompanyA;
using B = CompanyB;
using U = University;
using E = ExceptionDemo;
using C = Collection;


class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n======= MENU =======");
            Console.WriteLine("1. User Input");
            Console.WriteLine("2. ASCII Values");
            Console.WriteLine("3. Basic C# Concepts");
            Console.WriteLine("4. Namespaces & Aliasing");
            Console.WriteLine("5. OOP Concepts");
            Console.WriteLine("6. Exception Handling");
            Console.WriteLine("7. Collections");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option (1-8): ");
            Console.ResetColor();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter your GPA: ");
                    double gpa = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nName: {name}\nAge: {age}\nGPA: {gpa}");
                    break;

                case "2":
                    Console.WriteLine("\nUppercase Alphabets and their ASCII values:");
                    for (char c = 'A'; c <= 'Z'; c++)
                    {
                        Console.WriteLine($"Character: {c}, ASCII: {(int)c}");
                    }

                    int ascii = 65;
                    char character = (char)ascii;
                    Console.WriteLine($"\nASCII {ascii} corresponds to character: {character}");
                    break;

                case "3":
                    Console.WriteLine("\nBasic Data Type, Operators, Conditionals and Loops Output:");
                    datatype.show();
                    Operator.show();
                    conditionalStmt.show();
                    loops.show();
                    break;

                case "4":
                    Console.WriteLine("\nNamespace Usage with Aliases:");
                    A.User userA = new A.User(); // CompanyA
                    userA.display();

                    B.User userB = new B.User(); // CompanyB
                    userB.display();
                    break;

                case "5":
                    Console.WriteLine("\nOOP Concepts:");
                    U.Person personA = new U.Person("Rohit", 20);
                    personA.display();

                    U.Stu student1 = new U.Stu("Rohit", 20, 88);
                    student1.display();
                    student1.graduate();
                    break;

                case "6":
                    Console.WriteLine("\nRunning basic division exception demo:\n");
                    E.ExceptionHandling.Excephan();

                    Console.WriteLine("\n=============================\n");

                    Console.WriteLine("Running complete exception handling demo:\n");
                    E.ExceptionHandling.CompleteExceptionDemo();
                    break;

                case "7":
                    Console.WriteLine("\nCollections Demo:");
                    C.Collections.choice();
                    break;

                case "8":
                    Console.WriteLine("\nExiting program. Goodbye!");
                    exit = true;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please choose between 1 and 8.");
                    Console.ResetColor();
                    break;
            }
        }

        Console.ResetColor(); // Reset console color to default
    }
}
