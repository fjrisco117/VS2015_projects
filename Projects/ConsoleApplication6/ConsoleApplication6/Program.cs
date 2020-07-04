using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Joe");
            person.Introduce("Mosh");

            Console.WriteLine("Enter Any Key to Exit");
            Console.ReadKey();
        }
    }
}
