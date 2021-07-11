using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.FactoryMethod
{
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }
        public abstract void CreatePages();
    }
}
