using System;

namespace Zadatak_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, tn;

            Console.WriteLine("Prvi Broj?");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Drugi Broj?");
            sn = int.Parse(Console.ReadLine());

            Console.WriteLine("Treci Broj?");
            tn = int.Parse(Console.ReadLine());

            int rezjed = (fn + sn) * tn;
            int rezdva = fn * sn + sn * tn;

            Console.WriteLine("Rezultati su sljedeći: " + rezjed + " || " + rezdva);

            Console.Read();

        }
    }
}
