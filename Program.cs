using System;
using A = CompanyA;
using B = CompanyB;
using U = University;
class Program
{
    static void Main(string[] args)
    {
        //USER INPUT
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Integer input
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Double input
        Console.Write("Enter your GPA: ");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nName: {name}\nAge: {age}\nGPA: {gpa}");

        //Printing ascii characters , for lower case run the loop from a-z
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Console.WriteLine($"character:{c}, ASCII: {(int)c}");
        }

        //to see the character corresponding to the ascii value
        int ascii = 65;
        char character = (char)ascii;
        Console.WriteLine(character);  // Output: A


        datatype.show();
        Operator.show();
        conditionalStmt.show();
        loops.show();

        //NAMESPACES

        // CompanyA.User userA = new CompanyA.User();
        // userA.display();  // Output: Company A - User

        // CompanyB.User userB = new CompanyB.User();
        // userB.display();  // Output: Company B - User

        //or we can use "using" keyword at the top of the code to use the namespaces

        A.User userA = new A.User(); // called using the alias name 
        userA.display();
        B.User userB = new B.User();
        userB.display();

        //OOPS
        U.Person personA = new U.Person("rohit", 20);
        personA.display();

        U.Stu student1 = new U.Stu("rohit", 20, 88);
        student1.display();
        student1.graduate();

    }
}
