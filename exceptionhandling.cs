using System;

namespace ExceptionDemo
{
    // Custom exception class
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message) { }
    }

    public class ExceptionHandling
    {
        // This was your existing method
        public static void Excephan()
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero: " + e.Message);
            }
            finally
            {
                Console.WriteLine("This will always run.");
            }
        }

        // New: Unified method with multiple exception handling concepts
        public static void CompleteExceptionDemo()
        {
            try
            {
                // Age input
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int age))
                {
                    throw new FormatException("Age must be a number.");
                }

                if (age < 18)
                {
                    throw new AgeException("You must be at least 18 years old.");
                }

                // Division input
                Console.Write("Enter a number to divide 100: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int result = 100 / divisor;
                Console.WriteLine($"Result of division: {result}");

                // Null reference test
                string message = null;
                Console.WriteLine("Length of message: " + message.Length);
            }
            catch (AgeException ex)
            {
                Console.WriteLine("Custom Age Exception: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Math Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input Format Error: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Reference Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Complete Exception Handling Demo.");
            }
        }
    }
}
/*

types of exception:
_________________________________________________________________
| Exception Type             | When it Occurs                   |
| -------------------------- | -------------------------------- |
| `DivideByZeroException`    | Dividing a number by zero        |
| `NullReferenceException`   | Accessing a null object          |
| `IndexOutOfRangeException` | Accessing an invalid array index |
| `FormatException`          | Converting invalid data types    |
| `InvalidCastException`     | Invalid type casting             |
| `OverflowException`        | Arithmetic overflow              |
| `IOException`              | File/stream issues               |
| `FileNotFoundException`    | File not found                   |
| `ArgumentException`        | Invalid method arguments         |
-----------------------------------------------------------------
*/