using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.SayHi();

            //Dog dog2 = new Dog("John");
            //dog2.SayHi();
            //dog2.SayHi("Megan");

            //Dog dog = new Dog("Rex", "brown", 6);
            //Console.Write(dog.BioInformation());
            //Console.WriteLine("------------------------");

            Dog dog = new Dog();
            Console.Write("Enter dog name: ");
            dog.Name = Console.ReadLine();
            Console.Write("Enter dog fur color: ");
            dog.Color = Console.ReadLine();
            Console.Write("How old is the dog: ");
            dog.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------");
            Console.Write(dog.Information());

            Console.ReadLine();
        }
    }

    public class Dog
    {
        string name;
        string color;
        int age;

        public string Name
        {
            get { return String.Format("Hello, my name is {0}", name); }
            set { name = value; }
        }

        public string Color { get { return color; } set { color = value; } }

        public int Age { get { return age; } set { age = value; } }

        public Dog() { }

        public Dog(string name)
        {
            this.name = name;
        }

        public Dog(string name, string color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }

        public string Information()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Hello, ");
            result.AppendLine("My name is " + this.name);
            result.AppendLine("My fur color is " + this.color);
            result.AppendLine("I`m " + this.age + " years old");

            return result.ToString();
        }

        public void SayHi()
        {
            Console.WriteLine("Hello i`m " + this.name);
        }

        public void SayHi(string dogOwner)
        {
            Console.WriteLine("This is " + dogOwner + " dog!");
        }
    }
}