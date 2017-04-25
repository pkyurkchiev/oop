using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOO.Objects;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat1 = new Cat();
            //Cat cat2 = new Cat("Garfild", "orange");

            //cat1.Name = "Lucky";
            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat2.Name);

            //Lion lion1 = new Lion();
            //Cat lion2 = new Lion();
            //Lion lion3 = new Lion("Leo", "yellow", 150.1);

            //if(lion2 is Cat)
            //{
            //    Console.WriteLine("Lion1 is a cat");
            //}
            //if (lion2 is Lion)
            //{
            //    Console.WriteLine("Lion 1 is a lion");
            //}

            //lion3.Hello();
            //string name = string.Empty;
            //Console.WriteLine("Enter your puma name");
            //name = Console.ReadLine();

            //double weight = 0;
            //do
            //{
            //    Console.WriteLine("Enter your puma weight");
            //    string weightStr = Console.ReadLine();
            //    double.TryParse(weightStr, out weight);
            //} while (weight <= 0);

            //while (true)
            //{
            //    Console.WriteLine("Enter your puma weight");
            //    string weightStr = Console.ReadLine();
            //    double.TryParse(weightStr, out weight);

            //    if (weight > 0)
            //    {
            //        break;
            //    }
            //}

            //Puma puma1 = new Puma(name, weight);

            while (true)
            {
                Puma puma1 = new Puma("Lucky", 80);

                if (puma1.IsWhite)
                {
                    Console.WriteLine(puma1.Information());
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}