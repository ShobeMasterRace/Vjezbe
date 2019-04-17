using System;

namespace Zadatak_21
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

            if (fn > sn)
            {

                Console.WriteLine("\nRezultat: " + (fn - sn) * 2);


            }
            else
            {
                Console.WriteLine("\nRezultat: " + (fn - sn));


            }


            Console.ReadLine();

        }
    }
}
