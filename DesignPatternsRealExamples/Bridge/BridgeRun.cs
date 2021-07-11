using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Bridge
{
    class BridgeRun
    {
        public BridgeRun()
        {
            var customers = new Customers();
            // Set ConcreteImplementor
            customers.Data = new CustomersData("Chicago");
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            // Wait for user
            Console.ReadKey();
        }
    }
}
