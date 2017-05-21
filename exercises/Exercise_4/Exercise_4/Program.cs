using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_4.Objects;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Airplane airplane = new Airplane();

            bird.Fly();
            airplane.Fly();

            Console.ReadLine();
        }
    }
}
