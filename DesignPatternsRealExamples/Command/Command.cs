using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Command
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
