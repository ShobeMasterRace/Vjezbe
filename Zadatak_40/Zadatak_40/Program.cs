using System;

namespace Zadatak_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši prvi broj:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nUpiši drugi broj:");
            int n2 = int.Parse(Console.ReadLine());

            int n3 = 55;

            var broj1 = Math.Abs(n1 - n3); //Math.Abs (tražnje aposlutne vrijednosti pomoću Math system clase
            var broj2 = Math.Abs(n2 - n3);


            Console.WriteLine(broj1 == broj2 ? 0 : (broj1 < broj2 ? n1 : n2)); 


            Console.ReadLine();
        }
    }
}
