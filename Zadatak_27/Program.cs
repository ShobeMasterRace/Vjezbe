using System;
using System.Linq;

namespace Zadatak_27
{
    class Program
    {
        static void Main(string[] args)
        {

            String upis;
            Console.WriteLine("Upiši najmanje dvije riječi:  ");
            upis = Console.ReadLine();

            string[] arej = upis.Split(' ');

            foreach (String res in arej.Reverse())
           

            Console.Write(res + " ");


            Console.ReadLine();
        }
    }
    
}
