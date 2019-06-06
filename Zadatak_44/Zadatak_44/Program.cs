using System;

namespace Zadatak_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši riječ: ");

            string str = Console.ReadLine();

            var result = string.Empty; //.Empty = prazni string (read only)

            for (var i = 0; i < str.Length; i++)
            {

                if (i % 2 == 0) result += str[i]; //ako je 0 nakon dijeljenja sa 2, rezultat nek bude zbroj svih djeljenja nakon obavljanja loop-e, tj. svako drugo slovo

            }

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
