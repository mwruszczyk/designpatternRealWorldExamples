using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.AbstractFactory
{
    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
