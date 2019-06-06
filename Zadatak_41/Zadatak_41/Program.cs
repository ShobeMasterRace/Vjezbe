using System;
using System.Linq;

namespace Zadatak_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upiši riječ s najmanje jednim 'w' slovom u sebi: ");
            string rijec = Console.ReadLine();

            var brojalica = rijec.Count(a => a == 'w'); //.Count = svi characteri u stringu, (a => a == 'w') = sintaksa da se odredi koje slovo želimo da isčita iz stringa

            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");

            Console.WriteLine(brojalica >= 1 && brojalica <= 3); //ispiši mi "true" ako u sebi ima 'w'  jednako ili više od 1 puta ili manje ili jednako od 3 puta (1 - 3)

            Console.ReadLine();
        }
    }
}
