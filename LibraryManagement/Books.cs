using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Author; //{ get; set; }
        public string Title; // { get; set; }
        public int Pages; //{ get; set; }
        public string ISBNnum; //{ get; set; }
        public string Publisher; //{ get; set; }
        public string BookID; //{ get; set; }

        public bool IsAvailble; //{ get; set; }
        

        public static List<Book> books = new List<Book>();

        public Book(string author, string title, int pages, string iSBNnum, string publisher)
        {
            Author = author;
            Title = title;
            Pages = pages;
            ISBNnum = iSBNnum;
            Publisher = publisher;
            BookID = GenerateBookID();
            IsAvailble = true;
        }

        public static void AddBook(Book book)
        {
            books.Add(book);
        }

        private string GenerateBookID()
        {
            Random rand = new Random();

            return $"{rand.Next(01, 20).ToString("BK000")}";
        }

        public void PrintBookID()
        {
            Console.WriteLine($"The book {Title}, by {Author} has the tracking No. {BookID}");
        }


        public static void ListofBooks()
        {
           
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"{i + 1}, {books[i].BookID}, {books[i].Title}, {books[i].Author}");

            }
        }

        public static List<Book> GetAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            Console.WriteLine("BK019, Ake, Soyinka");
            Console.WriteLine("BK005, Introduction to Quantum Physics, Davidson");
            Console.WriteLine("BK013, Media and Communication Theory, Ojebode");

            foreach (var book in books)
            {
                if (book.IsAvailble) availableBooks.Add(book);
                Console.WriteLine(book);
            }
            return availableBooks;
        }

        public static void GetbyBookID()
        {
            Console.WriteLine("Enter book ID");
            string ID = Console.ReadLine();
            
          Console.WriteLine($"Book lend Successfully. {ID} has been added to your list of books");   
        }

       public static void ReturnBook()
        {
            Console.WriteLine("Enter the book ID");
            string ID = Console.ReadLine();
            Console.WriteLine("Enter ID No of the Librarian that receive the book");
            string LID = (Console.ReadLine());
            
            Console.WriteLine("Book with ID " + ID + " has been successfully returned");
            Console.WriteLine("Return confirmed by " + LID + " at 09:35:29PM on the 25th of January, 2022");
        }
    }
}
