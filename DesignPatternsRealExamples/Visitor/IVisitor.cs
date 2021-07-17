using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
