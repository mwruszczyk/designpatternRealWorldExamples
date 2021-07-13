using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
