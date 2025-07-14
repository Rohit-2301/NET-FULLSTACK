using System;
namespace University
{

    public class Person
    {
        public string name;
        public int age;
        //constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        public virtual void display()
        {
            Console.WriteLine("Name: " + name + ",Age: " + age);
        }


    }

    interface Igraduate
    {

        void graduate();
    }

    class Stu : Person, Igraduate
    {
        public int Marks;
        public Stu(string name, int age, int marks) : base(name, age)
        {
            this.Marks = marks;
        }

        public override void display()
        {
            Console.WriteLine($"Student: {name}, Age: {age}, Marks: {Marks}");
        }
        public void graduate()
        {
            Console.WriteLine($"{name} has graduated with {Marks}% marks.");
        }
    }


}