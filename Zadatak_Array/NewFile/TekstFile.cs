using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zadatak_Array.NewFile
{
    class TekstFile
    {
        public TekstFile()
        {
            

        }

        public void Napravi(int[] prvi, int[] drugi)
        {
            //deklariramo oba array-a u string da bi ga mogli koristit za stvaranje .txt datoteke
            string fileTxt1;
            string fileTxt2;
            fileTxt1 = string.Join(',', prvi);
            fileTxt2 = string.Join(',', drugi);

            //stvaranje nove .txt datoteke sa informacijama
            using (StreamWriter writetext = new StreamWriter("d://Tekstfajl.txt"))
            {
                Console.WriteLine("\nFile constructed");
                writetext.WriteLine("Evidentno je da array-i nisu istih vrijednosti");
                writetext.WriteLine(fileTxt1 + "\r\n" + fileTxt2);



            }



        }



    }
}
