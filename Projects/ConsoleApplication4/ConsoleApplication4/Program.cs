using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recurly;
using System.Net;



namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // using System.Net;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            // Use SecurityProtocolType.Ssl3 if needed for compatibility reasons

            var subdomain = "tier3fj1";
            var apiKey = "e9922993342845dbbc583c145b2ab811";
             
            Recurly.Configuration.SettingsManager.Initialize(apiKey, subdomain);
            
            string accountcode = "1111222233334444";
            var account = Accounts.Get(accountcode);
            System.Collections.Generic.List<Invoice> invoices = account.GetInvoices().ToList();
            foreach (var invoice in invoices)
                Console.WriteLine("Invoice: " + invoice.InvoiceNumber);

            var redemptions = account.GetActiveRedemption();
            Console.WriteLine(redemptions);

            var i = Invoices.Get(1000);
            Console.WriteLine("PO#: " + i.PoNumber);
            i.PoNumber = "hello";
            i.Update();
            Console.WriteLine("New PO#: " + i.PoNumber);

            /*
            try
            {
                var account = Accounts.Get("1111222233334444");
                Console.WriteLine("Account " + account);
            }            
            catch(NotFoundException e)
            {
                Console.WriteLine("Account not found.");
            }*/

            Console.WriteLine("Press any key to stop");
            Console.ReadLine();
        }
    }
}
