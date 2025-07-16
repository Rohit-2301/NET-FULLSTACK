using System;

namespace University
{
    // 🔹 Base Class
    public class Person
    {
        public string name;
        public int age;

        // Constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    // 🔹 Interface for Graduation
    interface Igraduate
    {
        void graduate();
    }

    // 🔹 Interface for Teaching
    interface ITeach
    {
        void teach();
    }

    // 🔹 Hierarchical + Interface (Person → Stu) + Igraduate
    public class Stu : Person, Igraduate
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

    // 🔹 Single Inheritance (Person → Teacher) + Multiple Interface
    public class Teacher : Person, ITeach, Igraduate
    {
        public string subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        public override void display()
        {
            Console.WriteLine($"Teacher: {name}, Age: {age}, Subject: {subject}");
        }

        public void teach()
        {
            Console.WriteLine($"{name} teaches {subject}.");
        }

        public void graduate()
        {
            Console.WriteLine($"{name} completed M.Ed in {subject}.");
        }
    }

    // 🔹 Multilevel Inheritance: Person → Staff → Admin
    public class Staff : Person
    {
        public string dept;

        public Staff(string name, int age, string dept) : base(name, age)
        {
            this.dept = dept;
        }

        public override void display()
        {
            Console.WriteLine($"Staff: {name}, Age: {age}, Department: {dept}");
        }
    }

    public class Admin : Staff
    {
        public string role;

        public Admin(string name, int age, string dept, string role) : base(name, age, dept)
        {
            this.role = role;
        }

        public override void display()
        {
            Console.WriteLine($"Admin: {name}, Age: {age}, Dept: {dept}, Role: {role}");
        }
    }
}
