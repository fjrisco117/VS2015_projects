using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recurly;
using System.Net;


namespace RecurlyTicket
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

            //string account = "777777777777777777";
            /*
            var account = new Account("777777777777777777")
            {
                Email = "jsmith@example.com",
                FirstName = "Joe",
                LastName = "Smith"
            };
            account.Create();*/

            var accountCode = Accounts.Get("777777777777777777");
            //var plan = Plans.Get("gold");
            //var subscription = new Subscription(accountCode, plan, "USD");
            //subscription.Create();

            var subscription = Subscriptions.Get("4fcaee54742a19413f66d440d099cc90");
            DateTime nextBillingDate = subscription.CurrentTermEndsAt;

            subscription.Cancel();


            /*
            System.Collections.Generic.List<Invoice> invoices = accountCode.GetInvoices().ToList();
            foreach (var invoice in invoices)

            {
                if (invoice == null)
                {
                    Console.WriteLine("No Invoice");
                }
            }

            //var redemptions = accountCode.GetActiveRedemption();
            //Console.WriteLine(redemptions);

            //var i = Invoices.Get(1000);
            //Console.WriteLine("PO#: " + i.PoNumber);
            //i.PoNumber = "1234";
            //i.Update();
            //Console.WriteLine("New PO#: " + i.PoNumber);


            //var plan = Plans.Get("gold");
            //var subscription = new Subscription(accountCode, plan, "USD");
            //subscription.Create();

            //Create plan
            /*var plan = new Plan("gold", "Gold plan");
            plan.UnitAmountInCents.Add("USD", 1000);
            plan.SetupFeeInCents.Add("USD", 6000);
            plan.PlanIntervalLength = 1;
            plan.PlanIntervalUnit = Plan.IntervalUnit.Months;
            plan.TaxExempt = false;
            plan.Create();

            Console.WriteLine("Press any key to stop");
            Console.ReadLine();*/
        }
    }
}