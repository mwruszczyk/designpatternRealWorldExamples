using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Memento
{
    class ProspectMemory
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
