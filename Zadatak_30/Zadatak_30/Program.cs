using System;

namespace Zadatak_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prvi = new int[]
            {
                1, 9, 7, 12, 5

            };
            int[] drugi = new int[]
            {

                2, 4, 3, 11, 1

            };

            //[{0}] se koristi kao placeholder da bi mogli isčitat array koji je naznačen
            //u liniji koda (poput 'prvi) sa Join separatorom
            Console.WriteLine("Prvi: [{0}]", string.Join(", ", prvi));
            Console.WriteLine("Drugi: [{0}]", string.Join(", ", drugi));

            Console.WriteLine("\nRezultat: ");


            //loop-a pomoću koje množimo svaki član jednog array-a sa istom pozicioniranim članom drugog array-a
            for (int i = 0; i < prvi.Length; i++)
            {

                Console.Write(prvi[i] * drugi[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
