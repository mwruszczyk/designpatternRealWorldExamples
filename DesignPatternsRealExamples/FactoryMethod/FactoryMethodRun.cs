using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.FactoryMethod
{
    class FactoryMethodRun
    {
        public FactoryMethodRun()
        {
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Raport();

            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }
            // Wait for user
            Console.ReadKey();



        }

    }
}
