using System;

namespace Class_6
{
    public class Ford : Vehicle
    {
        public string color { get; set; }

        public override void TurnOff()
        {
            Console.WriteLine("you have turned off the Ford");
        }

        public override void ServiceEngine()
        {
            Console.WriteLine("your Ford is due for service");
        }

        public override void Drive()
        {
            Console.WriteLine("The Ford is driving");
        }

        public override void Start()
        {
            Console.WriteLine("the Ford has started");
        }
    }
}