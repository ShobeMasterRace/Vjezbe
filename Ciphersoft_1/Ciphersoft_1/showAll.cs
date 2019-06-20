using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphersoft_1
{
    class showAll
    {
        public showAll()
            {





            }



        public void showing()
        {
            Console.WriteLine("2. Ispiši sve user-e");
            Console.WriteLine("---------------------");
            Console.WriteLine("Jeste li sigurni? Y/N");

            string odg = Console.ReadLine();

            if (odg.ToUpper().Equals("Y"))
            {

                int counter = 0;
                string line;

                // StreamReader metoda za read
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Danilo\Writelines.txt");

                while ((line = file.ReadLine()) != null)
                {

                    Console.WriteLine(line);
                    counter++;

                }

                file.Close();


                Console.ReadLine();



            }

            else
            {
                return;

            }

           








        }

    }
}
