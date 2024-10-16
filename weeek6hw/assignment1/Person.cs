using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Person
    {
        private string _name;
        private int _age;
        public string Name { get { return _name; } }
        public int Age { get { return _age; } }

        public Person(string Name, int Age)
        {  
            _name = Name; 
            _age = Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }
    }
}
