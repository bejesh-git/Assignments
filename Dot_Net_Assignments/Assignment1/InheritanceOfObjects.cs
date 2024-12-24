using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercisesCsharp
{
    internal class Person
    {
        private string pname;
        
        public Person(string name)
        {
            this.pname = name;
        }
        
        public string Pname
        {
            get { return pname; }
            set { this.pname = value; }
         }

        public override string ToString()
        {
            return "Hello! My name is " + Pname;
        }

    }


    internal class Student : Person
    {
        public Student(string name) : base(name) { }
        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }

    internal class Teacher : Person
    {
        public Teacher(string name) : base(name) { }
        public void Explain()
        {
            Console.WriteLine("Teacher is explaining");
        }
    }


}
