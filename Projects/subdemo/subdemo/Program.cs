using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Recurly;

namespace subdemo
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

            var subscriptionUuid = "512437ccef825deca31f4743fe9271dd";
            var subscription = Subscriptions.Get(subscriptionUuid);

            //subscription.Postpone(new DateTime(2019, 11, 21, 22, 00, 00), false);

            var change = new SubscriptionChange();
            //{
              //  RemainingBillingCycles = 30,
              //  TimeFrame = SubscriptionChange.ChangeTimeframe.Now
            //};

            change.CustomFields.Add(new CustomField("createdByUserID", "76a5f681-5751-4761-932d-ba6d17b50147"));
           // try
            //{

                Subscription.ChangeSubscription(subscriptionUuid, change);
            //}

            //catch (Exception Recurly){

            //}


            //Subscription.ChangeSubscription(subscriptionUuid, change);
            //var cycles = change.RemainingBillingCycles;


            //DateTime nextBillingDate = subscription.CurrentTermEndsAt;
            //subscription.Cancel();

            /*var change = new SubscriptionChange()
            {
                PlanCode = "YearPlan"
                //Quantity = 2
                //change.TimeFrame = SubscriptionChange.ChangeTimeframe.Renewal;
            };

            Subscription newSub = Subscription.PreviewChange(subscriptionUuid, change);
            //Invoice previewInvoice = newSub.InvoiceCollection.ChargeInvoice;*/
            //Console.WriteLine("Total bill cycles: " + cycles);
            //Console.WriteLine("Invoice Sunscription Subtotal: " + previewInvoice.TotalInCents);


            //var account = Accounts.Get("fj.any");
            //var plan = Plans.Get("silver20");
            //var sub = new Subscription(account, plan, "USD");
            //sub.CustomFields.Add(new CustomField("device_id", "hi"));
            //sub.Create();


            Console.WriteLine("Press enter to close...");
            Console.ReadLine();


        }
    }
}