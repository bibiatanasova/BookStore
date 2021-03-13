using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Controller
{
    public class StoreController
    {     
        private BookOperation bookOperation;
  
        private void GetAll()
        {
            List<Book> books = this.bookOperation.GetAllBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        private void CreateBook()
        {
            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Autor first name:");
            string authorFirstName = Console.ReadLine();
            Console.WriteLine("Autor last name:");
            string autorLastName = Console.ReadLine();
            Console.WriteLine("Genre:");
            string genre = Console.ReadLine();
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());

            Book book = new Book(0, title, genre, year, price, 0, authorFirstName, autorLastName);
            this.bookOperation.CreateBook(book);
        }

        private void UpdateBook()
        {
            Console.WriteLine("Book ID:");
            int idBook = int.Parse(Console.ReadLine());

            Console.WriteLine(this.bookOperation.GetBook(idBook));

            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Autor first name:");
            string authorFirstName = Console.ReadLine();
            Console.WriteLine("Autor last name:");
            string autorLastName = Console.ReadLine();
            Console.WriteLine("Genre:");
            string genre = Console.ReadLine();
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());

            Book book = new Book(idBook, title, genre, year, price, 0 , authorFirstName, autorLastName);

            this.bookOperation.UpdateBook(book);
        }

        private void GetBook()
        {
            Console.WriteLine("Book ID:");
            int id = int.Parse(Console.ReadLine());

            Book book = this.bookOperation.GetBook(id);

            Console.WriteLine(book);
        }

        private void DeleteBook()
        {
            Console.WriteLine("Book ID:");
            int id = int.Parse(Console.ReadLine());

            this.bookOperation.DeleteBook(id);
        }

    }
}
