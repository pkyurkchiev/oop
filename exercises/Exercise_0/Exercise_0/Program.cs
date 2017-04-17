using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отпечатване в конзолата
            Console.Write("Hello World! ");
            Console.WriteLine("Hello World! ");
            Console.WriteLine(6 + 2);

            //Инициализиране и присвояване на стойност
            int a;
            a = 6;
            int b = 4;

            int x, y, z = 50, v;

            x = y = z;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            x = 5 * 6;
            y = 30 / 5;
            z = 5 + (6 - 3 * 3 / 2);

            //Двата реда са Еквивалентни
            x = x + 5;
            x += 5;

            x -= 5;
            x *= 5;
            x /= 5;

            //Трите реда са еквивалентни
            x = x + 1;
            x++;// Инкрементиране
            ++x;// Инкрементиране

            x--;// Декриментиране
            --x;// Декриментиране

            Console.Write("x= ");
            Console.WriteLine(x);
            Console.Write("y= ");
            Console.WriteLine(y);
            Console.Write("z= ");
            Console.WriteLine(z);

            //Типове с плаваща запетая
            float flt = 3.14f;
            double dbl = 3.14156;
            decimal dcm = 3.14m;

            x = 2;
            dbl = 5 / (double)x;
            Console.WriteLine(dbl);
            dbl = 5.6 * 11;
            Console.WriteLine(dbl);
            dbl = 5.6 + 4 + 6.6 + 6f;
            Console.WriteLine(dbl);

            //Логически тип
            bool bl;
            bl = true;
            bl = false;
            bl = 5 > 6;
            bl = 5 == 6;
            bl = 5 <= 6;

            bl = (5 == 5) && (6 == 7);
            bl = (6 == 7) || (5 <= 6);

            Console.WriteLine(bl);

            //Тип чар
            char ch;
            ch = '1';       // ASCII code 49
            char ch2 = '2'; //ASCII code 50

            Console.WriteLine(ch + ch2);

            //Тип стринг
            string str;
            str = "";
            str = String.Empty;

            string str1 = "Hello";
            string str2 = "World";
            str = str1 + " " + str2;
            str = string.Format("{0} {1}", str1, str2);
            str = $"{str1} {str2}";
            
            Console.WriteLine(str);

            //Масиви
            int[] array_int = new int[30];
            array_int = new int[20];
            array_int = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(array_int[0]);
            Console.WriteLine(array_int[1]);
            Console.WriteLine(array_int[2]);
            Console.WriteLine(array_int[3]);
            Console.WriteLine(array_int[4]);

            array_int[0]++;
            Console.WriteLine(array_int[0]);

            Console.WriteLine("Enter int number: ");
            int aa = int.Parse(Console.ReadLine());
            
            Console.WriteLine(++aa);

            //Цикли
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            for (int i = 0; i < array_int.Length; i++)
            {
                Console.WriteLine(array_int[i]);
            }

            //Цикъл с пред условие
            int ii = 0;
            while (ii < 50)
            {
                Console.WriteLine(ii);
                ii += 5;
            }

            //Цикъл със след условие
            int num;
            do
            {
                Console.WriteLine("0 < num < 50");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0 || num >= 50);

            foreach (var item in array_int)
            {
                Console.WriteLine(item);
            }

            //Факториел със статична функция
            Console.WriteLine(Factorial(5));

            for (int s = 0; s < 5; s++)
            {
                Console.WriteLine(Fibonacii(s));
            }

            //Изчаква натискане на клавиш
            Console.ReadKey();
        }

        //Факториел
        public static int Factorial(int a)
        {
            if (a == 1) { return 1; }

            return a * Factorial(a - 1);
        }

        //Числата на фибоначи
        public static int Fibonacii(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }

            return a;
        }

        // Задача 1:
        // Напишете програма, която отпечатва в 
        // конзолата числата от 1 до N. Числото N
        // трябва да се чете от стандартния вход.

        //Задача 2:
        //Декларирайте две променливи от тип int.
        //Разменете стойностите им и ги отпечатайте.
    }
}
