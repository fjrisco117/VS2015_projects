using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Test
    {
        public void SayHello()
        {
            Console.WriteLine("Hello There!");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Please press any key to continue");
            //Console.ReadLine();

            var t = new Test();
            t.SayHello();

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Guess a number between 1 and 10");
            int num = Convert.ToInt32(Console.ReadLine());


            Random rand = new Random();
            int result = rand.Next(1, 11);

            while(num != result)
            {
                Console.WriteLine("Wrong Number! Try Again");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("You Got It!!!");
            Console.WriteLine("The Correct Number is " + num);

            Console.WriteLine("Please press any key to continue");
            Console.ReadLine();
        }
    }
}
