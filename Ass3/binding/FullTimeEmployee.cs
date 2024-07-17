using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.binding
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id ,string name ,int age,decimal s):base(id,name,age) { 
        salary = s;
        }
        public decimal salary { get; set; }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"Get Full time data Id = {Id} , Name = {Name} , Age = {Age}, Salary = {salary}");
        }
    }
}
