using System;
using DesignPatternsRealExamples.Builder;
using DesignPatternsRealExamples.Bridge;
using DesignPatternsRealExamples.Adapter;
using DesignPatternsRealExamples.AbstractFactory;
using DesignPatternsRealExamples.FactoryMethod;
using DesignPatternsRealExamples.Prototype;
using DesignPatternsRealExamples.Composite;
using DesignPatternsRealExamples.Decorator;
using DesignPatternsRealExamples.Facade;


namespace DesignPatternsRealExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new BuilderRun();  //builder
            //var bridge = new BridgeRun(); // bridge
            //var adapter = new AdapterRun(); //adapter
            //var abstractfactory = new AbstractFactoryRun(); //abstractfactory
            //var factoryMethod = new FactoryMethodRun(); //factorymethod
            //var prototype = new PrototypeRun(); //prototype
            //var composite = new CompositeRun(); // composite
            //var decorator = new DecoratorRun(); //decorator
              var facade = new FacadeRun();   //facade
        }
    }
}
