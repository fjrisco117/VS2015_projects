using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public enum ShippingMethod
    {
        RegularMail=1,
        RegisteredAirMail=2,
        Express=3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "RegularMail";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod.ToString());

            var method2 = "RegularMail";
            var anotherShipping = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), method2);
            Console.WriteLine(anotherShipping.ToString());

            Console.WriteLine("Enter Any Key to Terminate");
            Console.ReadKey();
        }
    }
}
