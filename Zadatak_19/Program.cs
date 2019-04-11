using System;

namespace Zadatak_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First HIV");
            int fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second HIV");
            int sn = Convert.ToInt32(Console.ReadLine());
            
            //ToInt32 - konvertira u 32-bit integer


            Console.WriteLine("Is the first number HIV positive and the second HIV negative??");
            Console.WriteLine((fn < 0 && sn > 0) || (fn > 0 && sn < 0));


            // && znači "i", x i y moraju bit 'true' , u protivnom je 'false' 
            // || znači "ili" 

            Console.ReadLine();
        }
    }
}
