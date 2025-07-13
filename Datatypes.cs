using System;
public class datatype

{
    public static void show()
    {
        Console.WriteLine("Data-types");
        int age = 20;
        double height = 5.8;
        char grade = 'A';
        string name = "rohit";
        bool isStudent = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("age: " + age);
        Console.WriteLine("height: " + height);
        Console.WriteLine("grade: " + grade);
        Console.WriteLine("is Student ?: " + isStudent);



        //Type Conversion- a) implicit (automatic)
        int x = 10;
        double y = x;
        Console.WriteLine("x: " + x + ", y: " + y);

        //b) explicit (manual)
        double a = 10.5;
        int b = (int)a;
        Console.WriteLine("a: " + a + ", b: " + b);

        //c) string conversion
        int number = 100;
        string numstr = number.ToString();
        Console.WriteLine("number: " + number + ", numstr: " + numstr);

        string str = "123";
        int parsenum = Convert.ToInt32(str);
        Console.WriteLine("str: " + str + ", parsenum: " + parsenum);

        //VAR KEYWORD- lets the system decide the datatype, but once assigned it cannot be changed
        var city = "delhi";
        var score = 95;
        Console.WriteLine(city.GetType());//to check the datatype of variable
        Console.WriteLine(score.GetType());

    }

}