using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.TemplateMethod
{
    class TemplateRun
    {
        public TemplateRun()
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}
