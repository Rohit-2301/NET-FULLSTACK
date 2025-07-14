using System;
using A = CompanyA;
using B = CompanyB;
using U = University;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello world \n");

        datatype.show();
        Operator.show();
        conditionalStmt.show();
        loops.show();

        // CompanyA.User userA = new CompanyA.User();
        // userA.display();  // Output: Company A - User

        // CompanyB.User userB = new CompanyB.User();
        // userB.display();  // Output: Company B - User

        //or we can use "using" keyword at the top of the code to use the namespaces

        A.User userA = new A.User(); // called using the alias name 
        userA.display();
        B.User userB = new B.User();
        userB.display();

        U.Person personA = new U.Person("rohit", 20);
        personA.display();

        U.Stu student1 = new U.Stu("rohit", 20, 88);
        student1.display();
        student1.graduate();
        
    }
}
