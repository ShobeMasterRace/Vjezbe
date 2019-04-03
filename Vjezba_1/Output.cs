using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Vjezba_1
{
    class Output
    {
        public Output()
        {


        }

        public void Outputting()
        {
            using (StreamWriter writer = new StreamWriter("D:/Tekst.txt", true)) {
                writer.WriteLine("Bamboozle\n");
                writer.WriteLine("Shobe\n");
                writer.WriteLine("Lookindis");

            }


        }
    }
}
