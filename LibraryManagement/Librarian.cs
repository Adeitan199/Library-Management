using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Librarian : Person
    {
        public string staffID { get; set; }
        public Librarian(string firstName, string lastName, string emailAddress, string address, long phoneNumber) : base(firstName, lastName, emailAddress, address, phoneNumber)
        {
            this.staffID = GenerateStaffID();

        }

        private string GenerateStaffID()
        {
            Random rand = new Random();

            return $" {rand.Next(15 , 45).ToString("SID000")}";
        }

        public void PrintLibDetails()
        {
            Console.WriteLine($"Dear {firstName} {lastName}, you are welcome to CPH Library, your staff Id number is {staffID}");
        }


        public static void RegisterLib()
        {
            Console.WriteLine(":::::::::::WELCOME TO CPH LIBRARY STAFF PORTAL::::::::::");

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

            Librarian staff1 = new Librarian(firstName, lastName, emailAddress, address, phoneNumber);
            staff1.PrintLibDetails();

            Console.WriteLine();
            Console.WriteLine("Enter 1 to add another book, enter two to exit");
            int fig = int.Parse(Console.ReadLine());

        }


        public static void AddBookToLib()
        {
            Console.WriteLine(":::::::::: WELCOME TO CPH LIBRARY STOCK:::::::::::::::");

            while (true)
            {
                Console.WriteLine("Enter ID No to Login");
                string ID = Console.ReadLine();


                Console.WriteLine("Enter Authors name");
                string Author = Console.ReadLine();

                Console.WriteLine("Enter Book Title");
                string Title = Console.ReadLine();

                Console.WriteLine("Enter pages of book");
                int Page = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter ISBN number");
                string ISBN = Console.ReadLine();

                Console.WriteLine("Enter Publishers name");
                string Publisher = Console.ReadLine();

                Book book1 = new Book(Author, Title, Page, ISBN, Publisher);
                Book.AddBook(book1);
                book1.PrintBookID();
                Book.ListofBooks();

                Console.WriteLine("Enter 1 to add another book, enter 2 to exit");
                int fig = int.Parse(Console.ReadLine());

               if (fig == 1)
               {
                   Book.ListofBooks();
                   continue;

               }
               else
               {
                   break;
               }


            }

        }
    }
    
}
    

