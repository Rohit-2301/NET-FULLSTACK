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

                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":
                        RunDemo(ArrayListDemo);
                        break;
                    case "2":
                        RunDemo(ListDemo);
                        break;
                    case "3":
                        RunDemo(DictionaryDemo);
                        break;
                    case "4":
                        RunDemo(HashSetDemo);
                        break;
                    case "5":
                        RunDemo(QueueDemo);
                        break;
                    case "6":
                        RunDemo(StackDemo);
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

        // Method to prompt user for default/user input and run demo
        static void RunDemo(Action<bool> demoMethod)
        {
            Console.Write("Use default values? (y/n): ");
            string input = Console.ReadLine().ToLower();
            bool useDefault = input == "y" || input == "yes";
            demoMethod(useDefault);
        }

        static void ArrayListDemo(bool useDefault)
        {
            ArrayList arr = new ArrayList();

            if (useDefault)
            {
                arr.Add(1);
                arr.Add("hello");
                arr.Add(3.14);
            }
            else
            {
                Console.Write("Enter number of elements for ArrayList: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter value (stored as object): ");
                    arr.Add(Console.ReadLine());
                }
            }

            Console.WriteLine("\nArrayList Elements:");
            foreach (var item in arr)
                Console.WriteLine(item);

            if (arr.Contains("hello"))
            {
                arr.Remove("hello");
                Console.WriteLine("After removing 'hello':");
                foreach (var item in arr)
                    Console.WriteLine(item);
            }
        }

        static void ListDemo(bool useDefault)
        {
            List<string> fruits = new List<string>();

            if (useDefault)
            {
                fruits.AddRange(new[] { "Apple", "Banana", "Cherry" });
            }
            else
            {
                Console.Write("Enter number of fruits: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter fruit {i + 1}: ");
                    fruits.Add(Console.ReadLine());
                }
            }

            Console.WriteLine("\nList<T> Elements:");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            Console.Write("Add a fruit: ");
            fruits.Add(Console.ReadLine());
            Console.Write("Remove a fruit: ");
            fruits.Remove(Console.ReadLine());

            Console.WriteLine("After Add & Remove:");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            Console.Write("Check if a fruit exists: ");
            string search = Console.ReadLine();
            Console.WriteLine($"Contains '{search}'? {fruits.Contains(search)}");
            Console.WriteLine($"Total items: {fruits.Count}");
        }

        static void DictionaryDemo(bool useDefault)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            if (useDefault)
            {
                students[101] = "Alice";
                students[102] = "Bob";
                students[103] = "Charlie";
            }
            else
            {
                Console.Write("Enter number of students: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    students[id] = name;
                }
            }

            Console.WriteLine("\nDictionary Elements:");
            foreach (var kvp in students)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            Console.Write("Enter key to remove: ");
            int removeKey = int.Parse(Console.ReadLine());
            students.Remove(removeKey);

            Console.WriteLine("After removal:");
            foreach (var kvp in students)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            Console.Write("Enter key to check: ");
            int checkKey = int.Parse(Console.ReadLine());
            Console.WriteLine($"Key {checkKey} exists? {students.ContainsKey(checkKey)}");
        }

        static void HashSetDemo(bool useDefault)
        {
            HashSet<int> numbers = new HashSet<int>();

            if (useDefault)
            {
                numbers.UnionWith(new[] { 1, 2, 3, 2, 4 });
            }
            else
            {
                Console.Write("Enter number of elements: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter number: ");
                    numbers.Add(int.Parse(Console.ReadLine()));
                }
            }

            Console.WriteLine("\nHashSet Elements:");
            foreach (int num in numbers)
                Console.WriteLine(num);

            Console.Write("Enter number to remove: ");
            numbers.Remove(int.Parse(Console.ReadLine()));

            Console.WriteLine("After removal:");
            foreach (int num in numbers)
                Console.WriteLine(num);
        }

        static void QueueDemo(bool useDefault)
        {
            Queue<string> queue = new Queue<string>();

            if (useDefault)
            {
                queue.Enqueue("First");
                queue.Enqueue("Second");
                queue.Enqueue("Third");
            }
            else
            {
                Console.Write("Enter number of queue items: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter item: ");
                    queue.Enqueue(Console.ReadLine());
                }
            }

            Console.WriteLine("\nQueue Elements:");
            foreach (string item in queue)
                Console.WriteLine(item);

            if (queue.Count > 0)
                Console.WriteLine($"Dequeued: {queue.Dequeue()}");

            Console.WriteLine("Queue after Dequeue:");
            foreach (string item in queue)
                Console.WriteLine(item);
        }

        static void StackDemo(bool useDefault)
        {
            Stack<string> stack = new Stack<string>();

            if (useDefault)
            {
                stack.Push("Bottom");
                stack.Push("Middle");
                stack.Push("Top");
            }
            else
            {
                Console.Write("Enter number of stack items: ");
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    Console.Write("Enter item: ");
                    stack.Push(Console.ReadLine());
                }
            }

            Console.WriteLine("\nStack Elements:");
            foreach (string item in stack)
                Console.WriteLine(item);

            if (stack.Count > 0)
                Console.WriteLine($"Popped: {stack.Pop()}");

            Console.WriteLine("Stack after Pop:");
            foreach (string item in stack)
                Console.WriteLine(item);
        }
    }
}
