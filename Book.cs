using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.Models
{
   public class Book
    {

        public Book(int id, string title, string genre, int year, decimal price, int idAuthor, int stock)        
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.Price = price;
            this.AuthorId = idAuthor;
           this.Stock = stock;
        }
        public Book()
        {

        }

        public Author  Author { get;  set; }
        [ForeignKey("Author")]
        public int AuthorId { get;  set; }
        public int Id { get;  set; }
        public string Title { get;  set; }
        public string Genre { get;  set; }
        public int Year { get;  set; }
        public decimal Price { get;  set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Title: {Title}  Genre: {Genre} Year: {Year}  Price: {Price}  Stock: {Stock}  AuthorId: {AuthorId}";
        }
    }
}
