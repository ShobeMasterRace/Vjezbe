using System;
using System.IO;
using Zadatak_Array.Usporedba; //zvanje folder-a da bi se mogao koristit u main-u
using Zadatak_Array.NewFile; // -||-

namespace Zadatak_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prvi = new int[]
            {
                1,4,3,11,0,-1,14


            };

            int[] drugi = new int[]
            {
                4,9,0,66,-2


            };

            // Zvanje nove instance klase
            Klasa Kla = new Klasa();
            Kla.Bla(prvi); // Zvanje metode iz klase sa potrebom varijablom 


            Klasadva Kladva = new Klasadva();
            Kladva.Bladva(drugi);

            Klasatri Klatri = new Klasatri();
            Klatri.Usporedi(prvi, drugi);

            TekstFile Teks = new TekstFile();
            Teks.Napravi(prvi, drugi);



            Console.WriteLine();
            Console.WriteLine(string.Join(',', prvi)); // convertanje int array-a u string, s ',' 
            Console.WriteLine(string.Join(',', drugi)); //izjašnjavamo s čim želimo da se lista odvaja

            





            Console.ReadLine();

        }
    }
}
