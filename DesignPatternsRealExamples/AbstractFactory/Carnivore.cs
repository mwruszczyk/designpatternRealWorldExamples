using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.AbstractFactory
{
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
}
