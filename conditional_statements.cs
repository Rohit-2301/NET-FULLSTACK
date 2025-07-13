using System;

public class conditionalStmt
{
    public static void show()
    {
        // IF / ELSE IF / ELSE Example
        Console.WriteLine("IF / ELSE IF / ELSE");
        int marks = 82;

        if (marks >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade: B");
        }
        else
        {
            Console.WriteLine("Grade: C");
        }

        Console.WriteLine();

        // NESTED IF Example
        Console.WriteLine("NESTED IF");
        int age = 20;
        bool hasID = false;

        if (age >= 18)
        {
            if (hasID)
                Console.WriteLine("Entry allowed");
            else
                Console.WriteLine("ID is required");
        }
        else
        {
            Console.WriteLine("Underage - Entry denied");
        }

        Console.WriteLine(); // Blank line

        // SWITCH CASE Example
        Console.WriteLine("SWITCH CASE");
        int day = 4;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        Console.WriteLine(); // Blank line

        // TERNARY OPERATOR Example
        Console.WriteLine("TERNARY OPERATOR");
        int number = 21;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine($"{number} is {result}");
    }
}
