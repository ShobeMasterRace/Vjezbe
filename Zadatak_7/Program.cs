using System;

namespace Zadatak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn, sn;
            Console.WriteLine("Prvi broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Drugi broj: ");
            sn = int.Parse(Console.ReadLine());

            int rezultatmno = fn * sn;
            int rezultatdje = fn / sn;
            int rezultatzbr = fn + sn;
            int rezultatodz = fn - sn;

            Console.WriteLine("Ovaj tu: " + fn + " I ovaj tu: " + sn + " Daju ovo tu dole ");
            Console.WriteLine("\nMnozenje: " + rezultatmno);
            Console.WriteLine("Dijeljenje: " + rezultatdje);
            Console.WriteLine("Zbrajanje: " + rezultatzbr);
            Console.WriteLine("Oduzimanje: " + rezultatodz);

            Console.Read();

        }
    }
}
