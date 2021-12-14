using System;

namespace lab3
{
    class Person
    {
        public string name { get; set; }
        int age;
        public int setAge
        {
            set { age = value; }
        }
        public int Greet
        {
            get { return age; }
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int x)
        {
            Console.WriteLine($"My age is: " + x + " years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    class StudentProfessorTest
    {
        string name { get; }
        public StudentProfessorTest(string _name)
        {
            name = _name;
        }
        public void Main()
        {
            Console.WriteLine("Good afternoon said " + name);

            var student = new Student();
            student.setAge = 20;
            student.name = "Vladislav";
            Console.WriteLine("Hello my name is  " + student.name + ", i'm student ");
            student.ShowAge(student.Greet);

            var teacher = new Professor();
            teacher.setAge = 63;
            teacher.name = "Anatoly";
            Console.WriteLine("Hello, I'm " + teacher.name + ",  " + teacher.Greet + " years old");
            teacher.Explain();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var test = new StudentProfessorTest("Dmytro");
            test.Main();
        }
    }
}

