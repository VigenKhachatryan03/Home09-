using System;
using System.Collections.Generic;
using System.Text;

namespace Home09_
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
                
        public int Age { get => age; set {
                if (value <0)   
                {
                    Console.WriteLine("Nooooooooooooo");
                }
                age = value;
            }}

        public Person (string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.Age = age;
        }

        public void print()
        {
            Console.WriteLine(name + " " + surname + " " + Age);
        }

        //public void SetAge(int a)
        //{
        //    if (a < 0)
        //    {
        //        Console.WriteLine("please enter a valid number for age");
        //    }
        //    else
        //    {
        //        age = a;
        //    }
        //}
    }
}
