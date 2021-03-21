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

        public BookOperation(DataConnection dataConnection)
        {
            this.database = dataConnection;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = null;
            books = this.database.Books.ToList();

            return books;
        }

        public Book GetBook(int id)
        {
            Book book = null;
            book = this.database.Books.FirstOrDefault(x => x.Id == id);

            return book;
        }

        public List<Author> GetAllAuthors()
        {
            List<Author> authors = null;
            authors = this.database.Authors.ToList();

            return authors;
        }

        public Author GetAuthor(int id)
        {
            Author author = null;
            author = this.database.Authors.FirstOrDefault(x => x.Id == id);
           
            return author;
        }

        public void AddAuthor(Author author)
        {
            this.database.Add(author);
            this.database.SaveChanges();
        }

        public void AddSeller(Seller seller)
        {
            this.database.Add(seller);
            this.database.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            this.database.Add(customer);
            this.database.SaveChanges();
        }

        public void CreateBook(Book book)
        {
            this.database.Add(book);
            this.database.SaveChanges();
        }

        public void UpdateBook(Book updateBook)
        {
            Book book = this.database.Books.FirstOrDefault(x => x.Id == updateBook.Id);

            if (book != null)
            {
                book.Price = updateBook.Price;
                this.database.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            Book book = this.database.Books.FirstOrDefault(x => x.Id == id);
            this.database.Books.Remove(book);
            this.database.SaveChanges();
        }

        public void SellBook( int idBook, int idSeller, int idCustomer)
        {
            Book book = this.database.Books.FirstOrDefault(x => x.Id == idBook);
            Seller seller = this.database.Sellers.FirstOrDefault(x => x.Id == idSeller);
            Customer customer = this.database.Customers.FirstOrDefault(x => x.Id == idCustomer);
            Sales sales = new Sales(0, idCustomer, idBook, idSeller);

            
            if (book.Stock != 0)
            {
                book.Stock--;
                if (book.Stock == 0)
                {
                    this.database.Books.Remove(book);
                }
            }
            else
            {
                Console.WriteLine("There is not available!");
            }
            this.database.Sales.Add(sales);
            this.database.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            Author author = this.database.Authors.FirstOrDefault(x => x.Id == id);
            this.database.Authors.Remove(author);
            this.database.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = this.database.Customers.FirstOrDefault(x => x.Id == id);
            this.database.Customers.Remove(customer);
            this.database.SaveChanges();
        }

        public void DeleteSeller(int id)
        {
            Seller seller = this.database.Sellers.FirstOrDefault(x => x.Id == id);
            this.database.Sellers.Remove(seller);
            this.database.SaveChanges();
        }
    }
}


