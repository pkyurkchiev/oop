using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_4.Interface;

namespace Exercise_4.Objects
{
    class Airplane : IFlyable
    {
        public void Fly() { Console.WriteLine("I`m an airplane, i can fly!"); }
    }
}
