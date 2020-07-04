using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsdemo
{
    class Program
    {
        static List<string> GenerateNames()
        {
            List<string> names = new List<string>();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }


        static void Main(string[] args)
        {
            var names = Program.GenerateNames();
            Program.PrintNames(names);

            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
