using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Adapter
{
    public class RichCompound : Compound
    {
        private string chemical;
        private ChemicalDataBank bank;


        public RichCompound(string chemical)
        {
            this.chemical = chemical;
        }

        public override void Display()
        {
            bank = new ChemicalDataBank();

            boilingPoint = bank.GetCriticalPoint(chemical, "B");
            meltingPoint = bank.GetCriticalPoint(chemical, "M");
            molecularWeight = bank.GetMolecularWeight(chemical);
            molecularFormula = bank.GetMolecularStructure(chemical);

            Console.WriteLine("\nCompound: {0} ------ ", chemical);
            Console.WriteLine(" Formula: {0}", molecularFormula);
            Console.WriteLine(" Weight : {0}", molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingPoint);


        }
    }
}
