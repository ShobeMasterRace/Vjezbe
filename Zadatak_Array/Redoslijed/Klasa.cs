using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_Array
{
    public class Klasa
    {
        
        //konstruktor
        public Klasa()
        {



        }

        //metoda (zovemo prvi array iz main-a)
        public void Bla(int[] prvi)

        {   //while = endless loop, dok se ne break-a
            while (true)
            {
                //alat za break while loop-a
                int counter = 0;

                //glavna logika - kreni od početka, provjeri dal je broj manji od sljedećeg sve dok ne dođeš do posljednjeg
                for (int i = 0; i < prvi.Length-1; i++)
                {
                    if (prvi[i] > prvi[i + 1])  //ako je broj veći od broja + 1 napravi switch 
                    {
                        int old = prvi[i + 1];    //ovo je
                        prvi[i + 1] = prvi[i];    //metoda 
                        prvi[i] = old;            //switch-a za jedno mjesto unaprijed(redoslijed o najmanjeg prema najvećem)

                        counter++;
                        
                        


                    }

                    else
                    {
                        


                    }



                    
                }
                if (counter == 0) //ako se "counter" broj vrati dva puta na istu početnu vrijednost od '0' break-aj 'while' loop
                {
                    break;


                }





            }

        }

        
       
        











    }
}
