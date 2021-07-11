using DesignPatternsRealExamples.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Bridge
{
    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}
