using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_20
{
    class Logika
    {
        public Logika()
        {

            
        }

        public void Log(int fn, int sn)
        {
            int tn;
            int ffn;

            tn = fn + sn;
            ffn = tn * 3;

            if (fn == sn)
            {
                Console.WriteLine("The result is: " + ffn);


            }

            else
            {
                Console.WriteLine("The result is: " + tn);


            }


        }


    }
}
