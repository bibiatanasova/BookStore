using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Controller
{
    public class BookOperation
    {
        private DataConnection database;

        public List<Book> GetAllBooks()
        {
            List<Book> books = null;

            using (database = new DataConnection())
            {
                books = this.database.Books.ToList();
            }

            return books;
        }

        public Book GetBook(int id)
        {
            Book book = null;

            using (database = new DataConnection())
            {
                book = this.database.Books.FirstOrDefault(x => x.IdBook == id);
            }

            return book;
        }

        public void CreateBook (Book book)
        {
            using (database=new DataConnection())
            {
                this.database.Add(book);
                this.database.SaveChanges();
            }
        }

        public void UpdateBook(Book updateBook)
        {
            using(database =new DataConnection())
            {
                Book book = this.database.Books.FirstOrDefault(x => x.IdBook == updateBook.IdBook);

                if (book != null)
                {
                    book.Price = updateBook.Price;
                    this.database.SaveChanges();
                }
            }
        }

        public void DeleteBook (int id)
        {
            using (this.database= new DataConnection())
            {
                Book book = this.database.Books.FirstOrDefault(x => x.IdBook == id);
                this.database.Books.Remove(book);
                this.database.SaveChanges();
            }
        }
    }
}
