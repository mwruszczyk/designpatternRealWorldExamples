using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Visitor
{
    public class Clerk : Employee
    {
        // Constructor
        public Clerk()
            : base("Kevin", 25000.0, 14)
        {
        }
    }
}
