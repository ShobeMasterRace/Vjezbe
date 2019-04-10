using System;

namespace Zadatak_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int ft, far;
            double cel;
            Console.WriteLine("Kolika je temperatura??");

            ft = int.Parse(Console.ReadLine());

            cel = ft + 273.15;
            Console.WriteLine("Celzij: " + cel);

            far = (ft * 9 / 5) + 32;
            Console.WriteLine("Ferenhejt: " + far);


            Console.ReadLine();
        }
    }
}
