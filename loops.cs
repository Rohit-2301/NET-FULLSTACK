using System;
public class loops
{
    public static void show()
    {
        // 🔹 FOR LOOP
        // Use when you know how many times to repeat
        Console.WriteLine("FOR LOOP: Print numbers 1 to 5");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("i = " + i);
        }

        Console.WriteLine();

        // 🔹 WHILE LOOP
        // Use when you want to repeat until a condition becomes false
        Console.WriteLine("WHILE LOOP: Print numbers 1 to 5");
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine("j = " + j);
            j++;
        }

        Console.WriteLine(); // Line break

        // 🔹 DO-WHILE LOOP
        // Runs the loop body at least once, even if the condition is false
        Console.WriteLine("DO-WHILE LOOP: Print numbers 1 to 5");
        int k = 1;
        do
        {
            Console.WriteLine("k = " + k);
            k++;
        } while (k <= 5);

        Console.WriteLine(); // Line break

        // 🔹 FOREACH LOOP
        // Use to iterate over collections like arrays or lists
        Console.WriteLine("FOREACH LOOP: Print names in an array");
        string[] names = { "Rohit", "Aman", "Sneha", "Zara" };

        foreach (string name in names)
        {
            Console.WriteLine("Name: " + name);
        }
    }
}
