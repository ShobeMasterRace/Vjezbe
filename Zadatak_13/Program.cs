using System;

namespace Zadatak_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn;
            Console.WriteLine("I tako, opet upiši broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine(fn + "" + fn + "" + fn);
            Console.WriteLine(fn + " " + fn);
            Console.WriteLine(fn + " " + fn);
            Console.WriteLine(fn + " " + fn);
            Console.WriteLine(fn + "" + fn + "" + fn);


            // very easily radimo pravokutnike lmao


            Console.ReadLine();
        }
    }
}
