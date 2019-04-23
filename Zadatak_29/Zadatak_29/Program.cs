using System;

namespace Zadatak_29
{
    class Program
    {
        static void Main(string[] args)
        {
            //heksadecimalni brojevi se razlikuju po tome što
            //od broja 10 nadalje se označavaju slovima poput A = 10, B = 11
            //zato heksadecimalne označujemo u obliku string

            Console.WriteLine("Upiši heksadecimalni broj: ");
            string heksa = Console.ReadLine();
            

            //pretvori string heksa(koji se tretira kao heksadecimalni broj uz pomoć NumberStyles.HexNumber) u int
            int deca = int.Parse(heksa, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Decimalni broj: " + deca);

            Console.ReadLine();
        }
    }
}
