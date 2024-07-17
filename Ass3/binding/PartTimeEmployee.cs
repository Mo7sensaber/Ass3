using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ass3.binding
{
    public class PartTimeEmployee:Employee
    {
        public int CountOFHour { get; set; }
        public int HourRate { get; set;}
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am partTimeEmployee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($"Get Full time data Id = {Id} , Name = {Name} , Age = {Age}, CountOfHour = {CountOFHour},HourRate = {HourRate}");
        }
    }
}
