﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.binding
{
    public class Employee
    {

        public Employee()
        {
            
        }
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetEmployeeType() {
            Console.WriteLine("I am Employee");
        }
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Id = {Id} , Name = {Name} , Age = {Age}");
        }

    }
}
