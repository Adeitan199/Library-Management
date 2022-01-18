using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class User:Person
    {
        public string userID; 

        public static  List<User> user = new List<User>();

        public User(string firstName, string lastName, string emailAddress, string address, long phoneNumber) : base(firstName, lastName, emailAddress, address, phoneNumber)
        {
            this.userID = GenerateUserID();   
        }


        private string GenerateUserID()
        {
            Random rand = new Random();

            return $"{rand.Next(10, 30).ToString("UID000")}";
        }

        public void PrintUserID()
        {
            Console.WriteLine($"Dear {firstName}  {lastName}, your are welcome to CPH Library, your User ID is {userID}");
        }

        public static void AddUser(User user)
        {
            User.AddUser(user);
        }

        public static void ListofUsers()
        {

            for (int i = 0; i <user.Count; i++)
            {
                Console.WriteLine($"{i + 1}, {user[i].userID}, {user[i].firstName}, {user[i].lastName}");

            }
        }


        public static void RegisterUser()
        {

            while (true)
            {
                Console.WriteLine(":::::::::::WELCOME TO CPH LIBRARY::::::::::");

                Console.WriteLine("Enter your first name");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter your last name");
                var lastName = Console.ReadLine();

                Console.WriteLine("Enter your email address");
                var emailAddress = Console.ReadLine();

                Console.WriteLine("Enter your home address");
                var address = Console.ReadLine();

                Console.WriteLine("Enter your phone number");
                var phoneNumber = long.Parse(Console.ReadLine());

                User user1 = new User(firstName, lastName, emailAddress, address, phoneNumber);
                //User.AddUser(user1);
                user1.PrintUserID();
                // User.ListofUsers();
                Console.WriteLine();

                

            }


        }

       public static void Login()
        {
            Console.WriteLine(":::::::::::WELCOME TO CPH LIBRARY LOGIN PORTAL:::::::::::");

            Console.WriteLine("Enter 1 to login as user");
            Console.WriteLine("Enter 2 to Login as Librarian and add books");
            int log = int.Parse(Console.ReadLine());

            if (log == 1)
            {
                Console.WriteLine("Enter your UserID to Login");
                string UID = Console.ReadLine();

                foreach (var num in user)
                {
                    if (num.userID == UID)
                    {
                        Console.WriteLine("You are Welcome to CPH Library");
                    }
                    else
                    {
                        Console.WriteLine("Invalid userID");
                        break;
                    } 
                }

                
                    Console.WriteLine("Press 1 to view List of Available books");
                    Console.WriteLine("Press 2 to borrow book");
                    Console.WriteLine("Press 3 to return book");
                    int ulog = int.Parse(Console.ReadLine());

                    if (ulog == 1)
                    {
                        Book.GetAvailableBooks();

                        Console.WriteLine("Press 1 to Borrow book");
                        Console.WriteLine("Press 2 to exit");
                        int bor = int.Parse(Console.ReadLine());

                        while (true)
                        {
                            if (bor == 1)
                            {
                                Book.GetbyBookID();
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else if (ulog == 2)
                    {
                        Book.GetbyBookID();
                    }
                    else if (ulog == 3)
                    {
                        Book.ReturnBook();
                    }
                
                
            }
            if (log == 2)
            {
                Librarian.AddBookToLib();
            }
        }

    }
}

