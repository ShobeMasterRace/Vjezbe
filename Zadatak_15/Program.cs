using System;

namespace Zadatak_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string bambo;

            string remove(string tks, int br)
            {

                return tks.Remove(br, 1);

            }

            Console.WriteLine("Upiši štagod ali bar da ima 5 slova ");
            bambo = Console.ReadLine();
            
            {

                Console.WriteLine(remove(bambo, 1));
                Console.WriteLine(remove(bambo, 4));
                Console.WriteLine(remove(bambo, 0));

            }
            
            //napravio sam više nego šta je trebalo za zadatak :P 

            Console.ReadLine();
        }
    }
}
