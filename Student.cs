using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Student
    {
        private string name;
        private int age;
        private string major;

        public Student( string name, int age, string major)
        { 
            this.name = name;
            this.age = age;
            this.major = major;
        }
        public void Introduce()
        {
            Console.WriteLine($"Hello, myself {name}, a {age} years old student with {major} major.");
        }
    }
}
