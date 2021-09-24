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

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();
            
            
        }
        
    }
}
