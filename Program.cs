using System;

namespace Class_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.Start();
            ford.Drive();
            ford.ShowColor();

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();
            dodge.ShowColor();

            Vehicle f1 = new Ford();

            //((Ford)f1).ShowColor(); // not safe
            //(f1 as Ford).ShowColor();
            f1.ShowColor();

            
            //polymorphism
            Vehicle d1 = new Dodge();
            d1.ShowColor();
            
            
        }
    }
}
