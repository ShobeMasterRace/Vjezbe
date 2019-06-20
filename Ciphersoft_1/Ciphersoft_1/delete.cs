using System;
using System.Collections.Generic;
using System.Text;

namespace Ciphersoft_1
{
    class delete
    {
        public delete()
        {




        }

        public void deleting()
        {
            Console.WriteLine("Enter a team you wish to delete: ");
            string userinput = Console.ReadLine();
            teams.Remove(userinput);
            foreach (var item in teams)
            Console.Write(item.ToString() + " ");





        }
                       


    }
}
