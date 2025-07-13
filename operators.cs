using System;
public class Operator
{
    public static void show()
    {
        // 🔹 Arithmetic Operators: +, -, *, /, %
        // These are used to perform basic math operations.
        int a = 10, b = 3;
        Console.WriteLine("🔹 Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));  // 13
        Console.WriteLine("a - b = " + (a - b));  // 7
        Console.WriteLine("a * b = " + (a * b));  // 30
        Console.WriteLine("a / b = " + (a / b));  // 3
        Console.WriteLine("a % b = " + (a % b));  // 1
        Console.WriteLine();

        // 🔹 Assignment Operators: =, +=, -=, *=, /=
        // Used to assign and update the value of variables.
        int x = 5;
        Console.WriteLine("🔹 Assignment Operators:");
        Console.WriteLine("Initial x = " + x);
        x += 3; // x = x + 3
        Console.WriteLine("x += 3 => " + x);
        x *= 2; // x = x * 2
        Console.WriteLine("x *= 2 => " + x);
        Console.WriteLine();

        // 🔹 Comparison Operators: ==, !=, <, >, <=, >=
        // Used to compare values; returns true or false.
        int num1 = 10, num2 = 20;
        Console.WriteLine("🔹 Comparison Operators:");
        Console.WriteLine("num1 == num2: " + (num1 == num2));  // false
        Console.WriteLine("num1 != num2: " + (num1 != num2));  // true
        Console.WriteLine("num1 < num2: " + (num1 < num2));    // true
        Console.WriteLine("num1 >= 10: " + (num1 >= 10));      // true
        Console.WriteLine();

        // 🔹 Logical Operators: && (AND), || (OR), ! (NOT)
        // Used with boolean values for decision making.
        bool isStudent = true;
        bool hasID = false;
        Console.WriteLine("🔹 Logical Operators:");
        Console.WriteLine("isStudent && hasID: " + (isStudent && hasID));  // false
        Console.WriteLine("isStudent || hasID: " + (isStudent || hasID));  // true
        Console.WriteLine("!isStudent: " + (!isStudent));                  // false
        Console.WriteLine();

        // 🔹 Unary Operators: ++, --
        // Increments or decrements a value by 1.
        int counter = 5;
        Console.WriteLine("🔹 Unary Operators:");
        Console.WriteLine("Initial counter = " + counter);
        Console.WriteLine("counter++ = " + (counter++));  // 5 (then becomes 6)
        Console.WriteLine("After counter++, counter = " + counter); // 6
        Console.WriteLine("++counter = " + (++counter));  // 7
    }
}
