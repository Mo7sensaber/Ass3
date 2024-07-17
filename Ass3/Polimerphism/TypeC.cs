using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Polimerphism
{
    internal class TypeC:TypeB
    {
        public int C { get; init; }
        public TypeC(int a ,int b , int c):base(a,b) {
        C = c;
        }
        public new void Func01()
        {
            Console.WriteLine("I am Drived (Grand cheild)");
        }
        public override void Func02()
        {
            Console.WriteLine($"Type B : A ={A}, B={B}, C={C}");
        }
    }
}
