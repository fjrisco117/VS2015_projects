using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookdemo
{
    class Program
    {

        static StringCollection GenerateNames()
        {
            StringCollection names = new StringCollection();
            names.Add("Gamma");
            names.Add("Vlissides");
            names.Add("Johnson");
            names.Add("Helm");
            return names;
        }

        static void PrintNames(StringCollection names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {
            var name = GenerateNames();
            PrintNames(name);
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
