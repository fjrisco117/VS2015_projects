using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recurly;
using Recurly.Configuration;
using System.Net;

namespace CreatePurchase
{

    class Program
    {
        private
        static void Main(string[] args)
        {

            var subscription = Subscriptions.Get("52774a5c11ce6f4413dbc04e82a58815");

            subscription.CustomFields = new List<CustomField>(new CustomField[] { new CustomField("food", "taco") });

            var dict = new Dictionary<string, string>();
            dict.Add("CustomerNotes", "Thanks for your business!");
            dict.Add("TermsAndConditions", "Payment can be sent to Acme Cloud, Inc.");

        }
    }
}

