using System;
using System.IO;

namespace Vjezba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TextWriter tw = new StreamWriter("D:/tekst.txt", true);
                tw.WriteLine("hecking bamboozle fren");
                tw.Close();
                Console.WriteLine("File created");
            }
            catch (Exception e)
            {
                Console.Write(e);

            }

            Console.Read();
        }
    }
}
