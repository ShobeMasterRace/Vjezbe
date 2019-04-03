using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vjezba_1
{
    class Input
    {

        public Input()
        {


        }


        public void Inputting()
        {
            try
            {
                Console.WriteLine("File created\n");
                Console.WriteLine("Press 'Enter' to show previous/all entries");
            }
            catch (Exception e)
            {
                Console.Write(e);

            }

            Console.Read();

            String path = @"D:\Tekst.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();

        }
    }

}

