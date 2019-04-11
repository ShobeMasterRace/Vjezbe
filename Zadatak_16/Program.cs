using System;

namespace Zadatak_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string vamotamo(string amo)
            {

                return amo.Length > 1
                    

                // ? = conditional operator
                ? amo.Substring(amo.Length - 1) + amo.Substring(1, amo.Length - 2) + amo.Substring(0, 1) : amo;

            }
            Console.WriteLine(vamotamo("What"));
            Console.WriteLine(vamotamo("The"));
            Console.WriteLine(vamotamo("Phucc"));



            Console.ReadLine();
        }
        
    }
}
