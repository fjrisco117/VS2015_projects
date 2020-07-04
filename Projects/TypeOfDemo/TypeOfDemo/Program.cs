using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfDemo
{
    class GenericCounter<T>
    {
        private static int value;

        static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }
    class Program
    {
        static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }

        static void Main(string[] args)
        {
            //PrintType<string>();
            //PrintType<int>();

            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();

            GenericCounter<int>.Display();
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();

            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
