using System;

namespace Zadatak_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int fn, sn, swoosh;
            Console.WriteLine("Upiši prvi broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši drugi broj: ");
            sn = int.Parse(Console.ReadLine());

            swoosh = fn;
            fn = sn;
            sn = swoosh;

            
            Console.WriteLine("\nSad je prvi broj: " + fn);
            Console.WriteLine("Sad je drugi broj: " + sn);




            Console.Read();

            
        }
    }
}
