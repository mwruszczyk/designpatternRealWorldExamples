﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
