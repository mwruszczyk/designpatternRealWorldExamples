using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Prototype
{
    class Color : ColorPrototype
    {
        int red;
        int green;
        int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                red, green, blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }
}
