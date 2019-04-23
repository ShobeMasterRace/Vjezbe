using System;

namespace Zadatak_26
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int dvzbroj;

                Console.WriteLine("Upiši dvoznamenkasti broj: ");
                dvzbroj = int.Parse(Console.ReadLine());


                int zbroj = 0;

                while (dvzbroj != 0)
                {

                    zbroj = zbroj + dvzbroj % 10;
                    dvzbroj = dvzbroj / 10;

                }


                Console.WriteLine("Zbroj dvoznamenkastog broja je: \n" + zbroj);
            }

            Console.ReadLine();
        }
    }
}
