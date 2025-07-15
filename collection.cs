/*

| Sr. | Collection Type           | Description                                     |
| --- | ------------------------- | ----------------------------------------------- |
| 1   | `Array`                   | Fixed-size, same-type sequence                  |
| 2   | `List<T>`                 | Dynamic array from `System.Collections.Generic` |
| 3   | `Dictionary<TKey,TValue>` | Key-value pairs                                 |
| 4   | `Stack<T>`                | LIFO structure                                  |
| 5   | `Queue<T>`                | FIFO structure                                  |
| 6   | `HashSet<T>`              | Unordered collection of unique elements         |
| 7   | Iteration & LINQ Basics   | Looping through collections efficiently         |

*/

using System;
namespace Collection
{
    public class Collections
    {
        //ARRAYS
        // Size is fixed once declared.
        // Index - based access.
        // Cannot add or remove elements dynamically.

        public static void Collectiondemo()
        {
            //taking user input 
            Console.WriteLine("Enter Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[size];
            Console.WriteLine("Enter Array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element{i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\narray elements are: ");
            foreach (int i in marks)
            {

                Console.WriteLine(i + " ");
            }
            //access specific index
            Console.WriteLine("marks of student 3 = " + marks[2]);

        }




    }
}