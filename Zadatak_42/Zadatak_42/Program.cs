using System;

namespace Zadatak_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 9, 10, 2, 1, 4, 44, 1, 6, 77, 14, 31, 2, 0, 9, 4 }; //array brojeva

            Console.WriteLine("Array: [{0}]", string.Join(", ", brojevi)); //ispiši cijeli sadržaj array-a '[{0}]' je placeholder za sadržaj array-a. Praktički brži način da se ispiše sadržaj array-a
            // .Join 
            var suma = 0;

            for (var i = 0; i < brojevi.Length; i++)  //for loop-a, kreni mi od 0, vrti do kraja array-a, +1
            {

                suma += brojevi[i]; //suma je jednaka zbroju svakog člana array-a 

            }

            Console.WriteLine("Suma: " + suma);


            Console.ReadLine();
        }
    }
}
