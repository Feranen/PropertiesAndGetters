using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesAndGetters.Models
{
    public class Student
    {
        // ann - Fields
        // Ann Properties
        // Ann() - methods


        // Pola - Fields
        private int _age;  // If field is private, it should start with _

        // Właściwości - Properties
        public string Name { get; set; } = "";// Getter and setter in shorter way

        public int Age {
            get { return _age; }
            set {
                if (value < 0) 
                {
                    // throw new ArgumentOutOfRangeException("value");

                    Console.WriteLine("Wprowadzony wiek jest niepoprawny");
                    return;
                }
                _age = value;
            } 
        }

        //Metody - Methods
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Age} lat");
        }

        //// Getters
        //public int GetAge()
        //{
        //    return age;
        //}

        //// Setters
        //public void SetAge(int age)
        //{
        //    if (age < 0)
        //    {

        //    }
        //    this.age = age;
        //}
    }
}
