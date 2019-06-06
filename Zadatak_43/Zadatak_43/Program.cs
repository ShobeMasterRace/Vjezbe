using System;

namespace Zadatak_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši riječ: ");

            string rijec = Console.ReadLine();

            if (rijec.Length < 4)

                Console.WriteLine(rijec.ToUpper()); //Ako je duljina stringa riječi manja od 4 charactera, postavi string u uppercase letters
            else

                Console.WriteLine(rijec); //u protivnom samo ispiši riječ

            Console.ReadLine();
        }
    }
}
