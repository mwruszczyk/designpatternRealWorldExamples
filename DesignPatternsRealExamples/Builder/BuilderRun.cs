using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Builder
{
    public class BuilderRun
    {

        public BuilderRun()
        {
            VehicleBuilder builder;

            Shop shop = new Shop();

            //Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();

        }
        


    }
}
