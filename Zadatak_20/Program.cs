using System;

namespace Zadatak_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn;
            int sn;
            

            Console.WriteLine("Enter the first number: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            sn = int.Parse(Console.ReadLine());


            Logika log = new Logika();
            log.Log(fn, sn);


            Console.ReadLine();
        }
    }
}
