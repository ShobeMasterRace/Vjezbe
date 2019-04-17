using System;

namespace Zadatak_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn;
            int sn;

            Console.WriteLine("Prvi broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Drugi broj: ");
            sn = int.Parse(Console.ReadLine());

            int result;

            result = fn + sn;

            if (result == 20 || fn == 20) 
            {
                Console.WriteLine("\nVery nice");

            }

            Console.WriteLine("\nRezultat je: " + result);

            Console.ReadLine();

        }
    }
}
