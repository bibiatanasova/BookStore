using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
   public class Book:Author
    {
        public Book(int idBook, string title, string genre, int year, decimal price, int idAuthor, string firstName, string lastName)
            :base ( idAuthor, firstName,  lastName)
        {
            this.IdBook = idBook;
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.Price = price;
        }

        public int IdBook { get; private set; }
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public int Year { get; private set; }
        public decimal Price { get;  set; }

        public override string ToString()
        {
            return $"{Title} - {FirstName} {LastName} - {Genre} - {Year} - {Price}";
        }
    }
}
