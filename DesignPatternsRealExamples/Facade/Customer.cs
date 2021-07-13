﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Facade
{
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name 
        {
            get { return name; }
        }

    }
}
