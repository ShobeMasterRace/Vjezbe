using System;

namespace Zadatak_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn;

            Console.WriteLine("Ajmo još jedan broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEto ga na: ");
            Console.WriteLine(fn + " " + fn + " " + fn + " " + fn);
            Console.WriteLine(fn + "" + fn + "" + fn + "" + fn);

            Console.WriteLine("{0} {0} {0} {0}", fn);
            Console.WriteLine("{0}{0}{0}{0}", fn);

            //basically {0} se koristi da jednostavnije ponavljamo funkciju??


            Console.ReadLine();


        }
    }
}
