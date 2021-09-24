using System;

namespace Class_6
{
    public abstract class Vehicle
    {
        public string make {get; set;}

        public string model {get; set;}
        
        public abstract void Drive();

        public virtual void ShowColor(){}

        //1. create new abstract method. 
        public abstract void TurnOff();
        
        //2. create a new virtual method.
        public virtual void ServiceEngine()
        {
            Console.WriteLine("your vehicle is due for service soon");
        }
        
        //implement in two fo our concrete classes

        public virtual void Start()
        {
            System.Console.WriteLine("the vehicle has started");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle stopped");
        }
    }
}