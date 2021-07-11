using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.FactoryMethod
{
    class Raport : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
