using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_Array.Usporedba
{
    class Klasatri
    {
        public Klasatri()
        {




        }

        public bool Usporedi(int[] prvi, int[] drugi)
        {


            if (prvi.Length == drugi.Length)
            {
                Console.WriteLine("Duljina array-a je ista");
                return true;

            }
            else
            {
                Console.WriteLine("Duljina array-a nije ista");
                return false;


            }



        }

        public bool Usporedi_dalje(int[] prvi, int[] drugi)
        {
            for (int i = 0; i < prvi.Length; i++)
            {
                if (prvi[i] == drugi[i])
                {
                    Console.WriteLine("Iste vrijednosti");
                    return true;



                }

                else
                {

                    Console.WriteLine("Različite vrijednosti");
                    return false;



                }

            }


            return true;

        }


    }
}
