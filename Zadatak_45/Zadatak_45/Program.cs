using System;
using System.Linq;

namespace Zadatak_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši broj:");

            int fn = int.Parse(Console.ReadLine());

            int[] brojalica = { 1, 2, 2, 3, 3, 4, 4, 5, 5, 7, 7, 7, 7, 7, 7 };

            Console.WriteLine("Broj = " + fn + " se prikazuje u array-u ovoliko puta: ");

            Console.WriteLine(brojalica.Count(x => x == fn));

            Console.ReadLine();
        }
    }
}
