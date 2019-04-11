using System;

namespace Zadatak_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string wtf;
            Console.Write("Malo teksta: \n");

            wtf = Console.ReadLine();


            if (wtf.Length >= 1)
            {
                var s = wtf.Substring(0, 1);


                Console.WriteLine(s + wtf + s);

            }


            Console.ReadLine();
        }
    }
}
