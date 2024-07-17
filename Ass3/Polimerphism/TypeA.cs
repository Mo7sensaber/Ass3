using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass3.Polimerphism
{
    internal class TypeA
    {
        public int A {  get; set; }
        public TypeA(int a)
        { 
            A = a;
        }
        public void Func01() {
            Console.WriteLine("I am a base (barent)");
        }
        public virtual void Func02()
        {
            Console.WriteLine($"TaypeA : A= {A}");
        }
    }
}
