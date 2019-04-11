using System;

namespace Zadatak_18
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int stroji(int fn, int sn)
                {

                    return fn == sn ? (fn + sn) * 3 : fn + sn;

                    // xx ? yy : zz
                    // Ako je xx 'true' , trigeraj yy, u protivnom trigeraj zz
                    // Tako funkcionira operator ?
                }

                Console.WriteLine(stroji(5, 6));
                Console.WriteLine(stroji(5, 5));
                Console.WriteLine(stroji(19, 20));



                Console.ReadLine();
            }
            
        }
    }
}
