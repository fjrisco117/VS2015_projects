using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recurly;
using System.Net;



namespace RecurlyAccountDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            //Use SecurityProtocolType.Ssl3 if needed for compatibility reasons

            var subdomain = "tier3fj1";
            var apiKey = "e9922993342845dbbc583c145b2ab811";

            Recurly.Configuration.SettingsManager.Initialize(apiKey, subdomain);
            
            var account = new Account("11223344556677")
            {
                Email = "jsmith@example.com",
                FirstName = "Joe",
                LastName = "Smith"
            };/*
            BillingInfo = new BillingInfo(new Account("1234123412341234"))
            {
                FirstName = "Johnny",
                LastName = "BeGood",
                CreditCardNumber = "4111-1111-1111-1111",
                VerificationValue = "123",
                ExpirationMonth = 12,
                ExpirationYear = 2019
            }*/

               //var account = Accounts.Get("111777");
               var info = account.BillingInfo;
                info.FirstName = "joe";
                info.LastName = "smith";
                info.PhoneNumber = "212-333-4444";
                info.VerificationValue = "123";
                info.ExpirationMonth = 11;
                info.ExpirationYear = 2020;
                info.Update();
            
            
            var plan = Plans.Get("gold");
            var subscription = new Subscription(account, plan, "USD");

            subscription.ShippingMethodCode = "fast_fast_fast";
            subscription.ShippingAmountInCents = 999;

            subscription.Create();
            //account.Create();
            
            Console.WriteLine("Press any key to stop");
            Console.ReadLine();
        }
    }
}