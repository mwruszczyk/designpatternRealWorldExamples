﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Facade
{
    public class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
