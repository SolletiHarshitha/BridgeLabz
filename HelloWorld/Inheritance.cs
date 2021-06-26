using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Inheritance
    {
        public string studentName;
        public int studentAge;
        public void Display(string name,int age)
        {
            this.studentName = name;
            this.studentAge = age;
            Console.WriteLine("Name : "+name);
            Console.WriteLine("Age : "+age);
        }
    }
    class Student : Inheritance
    {
        public Student()
        {
            Console.WriteLine("Student Details");
        }
    }
}
