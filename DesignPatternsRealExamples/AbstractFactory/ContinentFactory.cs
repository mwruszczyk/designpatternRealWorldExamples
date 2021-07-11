using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.AbstractFactory
{
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
