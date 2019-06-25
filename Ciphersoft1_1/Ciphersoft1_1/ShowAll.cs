using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ciphersoft1_1
{
    public class ShowAll
    {
        public ShowAll()
        {



        }

        public void ShowsAll()
        {


            Console.WriteLine("____________________________");
            Console.WriteLine("\nStisni Y za cijelu listu: ");

            string booz = Console.ReadLine();

            if (booz.ToUpper().Equals("Y"))
            {

                string text = File.ReadAllText(@"C:\Users\Public\WriteLines.txt");
                Console.WriteLine(text);




            }







            Console.ReadLine();
        }


    }
}
