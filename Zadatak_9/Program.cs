using System;

namespace Zadatak_9
{
    class Program
    {
        static void Main(string[] args)
        {

            //kalkulacije prosjeka
            int fn, sn, tn, ffn;
            Console.WriteLine("Upiši prvi broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši drugi broj: ");
            sn = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši treci broj: ");
            tn = int.Parse(Console.ReadLine());

            Console.WriteLine("Upiši cetvrti broj: ");
            ffn = int.Parse(Console.ReadLine());


            int evrd = (fn + sn + tn + ffn) / 4;
            
            Console.WriteLine("Evrđ je: " + evrd );




            Console.Read();




         
        }
    }
}
