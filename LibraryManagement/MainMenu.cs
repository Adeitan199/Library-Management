using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class MainMenu
    {
        public static void menu()
        {
           
            while (true)
            {
                Console.WriteLine("Press 1 to register user");
                Console.WriteLine("Press 2 to regster Librarian");
                Console.WriteLine("Press key 3 to login");
                Console.WriteLine("Press key 4 to Exit");
                
                int response = int.Parse(Console.ReadLine());

                if(response == 1)
                {
                    User.RegisterUser();
                    break;
                }


                else if (response == 2)
                {
                    Librarian.RegisterLib();
                    break;
                }

                else if(response == 3)
                {
                    User.Login();
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
