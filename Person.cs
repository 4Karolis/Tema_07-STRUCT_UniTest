using System;
using System.Collections.Generic;
using System.Text;

namespace Tema_08___Struckts___UnitTests
{
    struct Person
    {
        public string Name;
        public string LastName;
        public int Age;

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        public void SayMyFullName()
        {
            Console.WriteLine($"My name is: {Name} and my last name is: {LastName}");
        }
    }
}
