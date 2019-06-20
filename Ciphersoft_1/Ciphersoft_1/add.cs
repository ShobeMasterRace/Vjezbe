using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphersoft_1
{
    class add
    {
        public add()
        {



        }

        public void adding()
        {
            Console.WriteLine("1. Dodaj User-a");
            Console.WriteLine("----------------");


            string ime;
            string prezime;
            string adresa;
            int oib;


            Console.WriteLine("Upiši Ime: ");
            ime = Console.ReadLine();

            Console.WriteLine("\nUpiši Prezime: ");
            prezime = Console.ReadLine();

            Console.WriteLine("\nUpiši Adresu: ");
            adresa = Console.ReadLine();

            Console.WriteLine("\nUpiši Oib: ");
            oib = int.Parse(Console.ReadLine());

            string bla = oib.ToString();

            string[] skup = { ime, prezime, adresa, bla };
            System.IO.File.AppendAllLines(@"C:\Users\Danilo\Writelines.txt", skup);


        }




    }
}
