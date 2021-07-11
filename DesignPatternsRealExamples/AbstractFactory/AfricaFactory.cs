using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.AbstractFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildbeest();
        }
                
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
