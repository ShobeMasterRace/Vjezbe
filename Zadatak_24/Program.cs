using System;

namespace Zadatak_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napravimo dva stringa, prvi koji će nam koristit da nam spremi najdulju riječ, a drugi u kojem je rečenica
            string duga = "";
            string recenica = "Išao medo u dućan, nije rekao dobar dan";

            //Napravimo array stringova koji će nam rečenicu raspodijelit na riječi sa (' ') npr. --- ('Išao') ('medo')
            string[] arej = recenica.Split(' ');

            //For loop-a da prođe svaku riječ od početka do kraja
            for (int i = 0; i < arej.Length; i++)
            {

                
                if (arej[i].Length > duga.Length)
                {
                    //napravimo switch za svaku dužu riječ do ne dobijemo najdužu
                    duga = arej[i];


                }


            }


            Console.WriteLine("Najduža riječ je: " + duga);

            Console.ReadLine();
        }
    }
    }

