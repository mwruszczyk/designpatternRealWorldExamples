using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Adapter
{
    public class Compound
    {
        protected float boilingPoint;
        protected float meltingPoint;
        protected double molecularWeight;
        protected string molecularFormula;

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown-------");
        }
    }
}
