using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int selected;
            List<object> listDoc = new List<object>();
            StringBuilder menu = new StringBuilder();
            menu.AppendLine("Select type document:");
            menu.AppendLine("1. Invoice");
            menu.AppendLine("2. Contract");
            menu.AppendLine("3. Book");
            
            Console.WriteLine(menu);

            do
            {
                int.TryParse(Console.ReadLine(), out selected);
                if (selected > 0 && selected <= 3) break;
            } while (true);

            // TODO : 

            Console.ReadLine();
        }
    }
}
