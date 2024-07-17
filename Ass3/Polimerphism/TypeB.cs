using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Polimerphism
{
    internal class TypeB :TypeA
    {
        public int B {  get; set; }
        public TypeB(int a, int b):base(a) {
        B = b;
        }
        public new void Func01() {
            Console.WriteLine("I am Drived (cheild)");
        }
        public override void Func02() {
            Console.WriteLine($"Type B : A ={A}, B={B}");
        }

    }
}
