using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recurly;
using Recurly.Configuration;
using System.Net;

namespace GetSubscriptionDetails
{

    class Program
    {
        private
        static void Main(string[] args)
        {
            try
            {
                // using System.Net;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                // Use SecurityProtocolType.Ssl3 if needed for compatibility reasons
                var subdomain = "tier3fj1";
                var apiKey = "e9922993342845dbbc583c145b2ab811";

                Recurly.Configuration.SettingsManager.Initialize(apiKey, subdomain);

                var subscription = Subscriptions.Get("5133015102bce8a1e963204305ad92b3");
                //DateTime nextBillingDate = subscription.CurrentTermEndsAt;

                var change = new SubscriptionChange()
                {
                   UnitAmountInCents = 786
                };

                Subscription preview = Subscription.PreviewChange(subscription.Uuid, change);
                System.Console.WriteLine("Preview Next Invoice Amount: " + preview.InvoiceCollection.ChargeInvoice.TotalInCents);
                ///var preview = Subscription.PreviewChange(subscription.Uuid, );
            }

            /*
            var account = Accounts.Get("1");

            //var transaction = new Transaction(account, 100, "USD");
            //transaction.Create();
            var info = account.BillingInfo;
            Console.WriteLine("Credit Card: " + info.FirstSix);

            var transaction = Transactions.Get("50b8aee7c829151f4e1e35424ba662c0");

            Console.WriteLine(transaction.Account.BillingInfo.FirstSix);
            Console.WriteLine(transaction.Account.BillingInfo.LastFour);
            Console.WriteLine(transaction.Account.BillingInfo.CardType);*/


            /*

            var subscriptionUuid = "50daf6a9d2c4e5a480ecb042948e60d4"; // an existing subscription uuid
            var subscription = Subscriptions.Get(subscriptionUuid);

            DateTime nextBillingDate = subscription.CurrentTermEndsAt;
            ShippingAddress hello = subscription.ShippingAddress;


            Console.WriteLine(value: "Next Bill Date: " + nextBillingDate);// returns the next billing date
            Console.WriteLine("Amount due: " + subscription.UnitAmountInCents);


            var change = new SubscriptionChange()
            {
                UnitAmountInCents = 50
            };

            Subscription subscriptionPreview = Subscription.PreviewChange(subscriptionUuid, change);
            Console.WriteLine("Subscription Preview Amount: " + subscriptionPreview.UnitAmountInCents);

            Console.WriteLine("Current amount due: " + subscription.UnitAmountInCents);

            //var newInvoice = Subscription.PreviewChange(subscriptionUuid, change);
            //Console.WriteLine("Invoice Amount: " + newInvoice.InvoicePreview.TotalInCents);

            //var accountCode = "1";
            //var invoice = new Invoice();
            //invoice.Preview(accountCode);
            //Console.WriteLine("Invoice Amount: ")


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();


        }*/

            catch (ValidationException e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.TransactionError.CustomerMessage);
            }
        }
    }
}
