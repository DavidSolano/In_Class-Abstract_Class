using System;

namespace Class_6
{
    public class Dodge : Vehicle
    {
        public override void TurnOff()
        {
            Console.WriteLine("your Dodge has turned off");
        }

        public override void ServiceEngine()
        {
            Console.WriteLine("your Dodge is due for service");
        }

        public override void Drive()
        {
            Console.WriteLine("the Dodge is running");
        }
    }
}