using System;

namespace Zadatak_11
{
    class Program
    {
        //Učimo 'if' i 'else' lol
        static void Main(string[] args)
        {
            int fa;

            Console.WriteLine("Broj godina?");
            fa = int.Parse(Console.ReadLine());

            if (fa < 20)
            {
                Console.WriteLine("Izgledaš starije od " + fa);



            }
            else
            {
                Console.WriteLine("Ne, ne, napiši manje od 20 lol");

            }


            Console.ReadLine();


        }
    }
}
