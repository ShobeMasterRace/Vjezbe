using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_Array
{
    class Klasadva
    {
        public Klasadva()
        {



        }


        public void Bladva(int[] drugi)
        {

            while (true)
            {
                
                int counterdva = 0;

                
                for (int i = 0; i < drugi.Length - 1; i++)
                {
                    if (drugi[i] > drugi[i + 1])  
                    {
                        int old = drugi[i + 1];    
                        drugi[i + 1] = drugi[i];    
                        drugi[i] = old;            

                        counterdva++;




                    }

                    else
                    {



                    }




                }
                if (counterdva == 0) //ako se "counter" broj vrati dva puta na istu početnu vrijednost od '0' break-aj 'while' loop
                {
                    break;


                }





            }




        }





    }
}
