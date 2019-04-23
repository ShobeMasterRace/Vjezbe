using System;
using System.IO;

namespace Zadatak_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //dio System.IO namespace-a (fileinfo) koji se koristi za različite svrhe file-ova (kreiranje, modificiranje, brisanje, isčitavanje)
            //u ovom slučaju za izračun koliko file zauzima u bajtovima (tj. length.Tostring() ) 
            FileInfo fajl = new FileInfo("D:\\tekst.txt");

            Console.WriteLine("Veličina file u bajtovima: " + fajl.Length.ToString());


            Console.ReadLine();
        }
    }
}
