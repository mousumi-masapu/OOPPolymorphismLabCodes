using System;

namespace ImplementingPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation MO = new MathOperation();
            Console.WriteLine(MO.Add(1, 2));
            Console.WriteLine(MO.Add(2.2, 3.3,5.5));
            Console.WriteLine(MO.Add(2.2m, 3.3m, 4.4m));
            Console.ReadLine();
        }
        
    }
}
