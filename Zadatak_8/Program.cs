using System;

namespace Zadatak_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Seksi tablica mnozenja
            int fn, jen, dva, tri, cetri, pet, sest, sedam, osam, devet, deset;

            Console.WriteLine("Unesi jebeni broj: ");
            fn = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEvo ti na");

            jen = fn * 1;
            dva = fn * 2;
            tri = fn * 3;
            cetri = fn * 4;
            pet = fn * 5;
            sest = fn * 6;
            sedam = fn * 7;
            osam = fn * 8;
            devet = fn * 9;
            deset = fn * 10;

            Console.WriteLine(jen);
            Console.WriteLine(dva);
            Console.WriteLine(tri);
            Console.WriteLine(cetri);
            Console.WriteLine(pet);
            Console.WriteLine(sest);
            Console.WriteLine(sedam);
            Console.WriteLine(osam);
            Console.WriteLine(devet);
            Console.WriteLine(deset);

            //superpro

            Console.Read();


        }
    }
}
