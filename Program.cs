using System;

namespace Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, tn;
            Console.WriteLine("Upiši prvi fakin broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši drugi fakin broj: ");
            sn = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši treći fakin broj: ");
            tn = int.Parse(Console.ReadLine());

            int rezultat = fn * sn * tn;

            Console.WriteLine("\nEvo ti na rezultat: " + rezultat);

            Console.Read();
            

        
        }
    }
}
