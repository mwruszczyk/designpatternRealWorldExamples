using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Observer
{
    public interface IInvestor
    {
        void Update(Stock stock);
    }
    
}
