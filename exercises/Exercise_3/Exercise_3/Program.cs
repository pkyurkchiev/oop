using Exercise_3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int action = 0;
            double a = 0, h = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Actions:");
            sb.AppendLine("1. Calc square perimeter");
            sb.AppendLine("2. Calc triangle perimeter");
            sb.AppendLine("3. Calc square area");
            sb.AppendLine("4. Calc triangle area");

            Console.WriteLine(sb.ToString());

            do
            {
                int.TryParse(Console.ReadLine(), out action);

                if (action > 0)
                    break;
                else
                    Console.Write("Please enter correct number:");
            } while (true);

            do
            {
                Console.Write("Enter a: ");
                double.TryParse(Console.ReadLine(), out a);
                if (a > 0) break;
            } while (true);

            switch (action)
            {
                case 1:
                    Square squere = new Square("white", "black", a);
                    Console.WriteLine(squere.CalcPerimeter());
                    break;
                case 2:
                    Triangle triangle = new Triangle("white", "black", a);
                    Console.WriteLine(triangle.CalcPerimeter());
                    break;
                case 3:
                    Square squere2 = new Square("white", "black", a);
                    Console.WriteLine(squere2.CalcArea());
                    break;
                case 4:
                    do
                    {
                        Console.Write("Enter h: ");
                        double.TryParse(Console.ReadLine(), out h);
                        if (h > 0) break;
                    } while (true);

                    Triangle triangle1 = new Triangle("white", "black", a, h);
                    Console.WriteLine(triangle1.CalcArea());
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
