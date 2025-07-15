using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    public class Collections
    {

        public static void choice()
        {
            bool exit = false;

            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n======= COLLECTION MENU =======");
                Console.WriteLine("1. ArrayList");
                Console.WriteLine("2. List<T>");
                Console.WriteLine("3. Dictionary<TKey, TValue>");
                Console.WriteLine("4. HashSet<T>");
                Console.WriteLine("5. Queue<T>");
                Console.WriteLine("6. Stack<T>");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option (1-7): ");
                Console.ResetColor();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ArrayListDemo();
                        break;

                    case "2":
                        ListDemo();
                        break;

                    case "3":
                        DictionaryDemo();
                        break;

                    case "4":
                        HashSetDemo();
                        break;

                    case "5":
                        QueueDemo();
                        break;

                    case "6":
                        StackDemo();
                        break;

                    case "7":
                        exit = true;
                        Console.WriteLine("Exiting Collections Menu...");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please choose between 1 and 7.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        // All methods remain private since they're only used internally.
        static void ArrayListDemo()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add("hello");
            arr.Add(3.14);

            Console.WriteLine("\nArrayList Elements:");
            foreach (var item in arr)
                Console.WriteLine(item);

            arr.Remove("hello");
            Console.WriteLine("After removing 'hello':");
            foreach (var item in arr)
                Console.WriteLine(item);
        }

        static void ListDemo()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            Console.WriteLine("\nList<T> Elements:");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            fruits.Add("Mango");
            fruits.Remove("Banana");
            Console.WriteLine("After Add & Remove:");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            Console.WriteLine($"Contains 'Apple'? {fruits.Contains("Apple")}");
            Console.WriteLine($"Total items: {fruits.Count}");
        }

        static void DictionaryDemo()
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {101, "Alice"},
                {102, "Bob"},
                {103, "Charlie"}
            };

            Console.WriteLine("\nDictionary Elements:");
            foreach (var kvp in students)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            students.Remove(102);
            Console.WriteLine("After removing key 102:");
            foreach (var kvp in students)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            if (students.ContainsKey(101))
                Console.WriteLine("Key 101 exists.");
        }

        static void HashSetDemo()
        {
            HashSet<int> numbers = new HashSet<int> { 1, 2, 3 };

            numbers.Add(2); // Duplicate won't be added
            numbers.Add(4);

            Console.WriteLine("\nHashSet Elements:");
            foreach (int num in numbers)
                Console.WriteLine(num);

            numbers.Remove(3);
            Console.WriteLine("After removing 3:");
            foreach (int num in numbers)
                Console.WriteLine(num);
        }

        static void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            Console.WriteLine("\nQueue Elements:");
            foreach (string item in queue)
                Console.WriteLine(item);

            Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            Console.WriteLine("Queue after Dequeue:");
            foreach (string item in queue)
                Console.WriteLine(item);
        }

        static void StackDemo()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Bottom");
            stack.Push("Middle");
            stack.Push("Top");

            Console.WriteLine("\nStack Elements:");
            foreach (string item in stack)
                Console.WriteLine(item);

            Console.WriteLine($"Popped: {stack.Pop()}");

            Console.WriteLine("Stack after Pop:");
            foreach (string item in stack)
                Console.WriteLine(item);
        }
    }
}
