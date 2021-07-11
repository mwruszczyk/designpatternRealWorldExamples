using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Adapter
{
    class AdapterRun
    {
        public AdapterRun()
        {
            Compound unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            // Wait for user
            Console.ReadKey();
        }
    }
}
