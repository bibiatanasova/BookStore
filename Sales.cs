using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey ("Customer")]
        public int CustomerId { get; set; }
        public Book Book { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Seller Seller { get; set; }        
        [ForeignKey("Seller")]
        public int SellerId { get; set; }           

        public Sales()
        {

        }

      
        public Sales(int id, int idCustomer,int idBook, int idSeller)
        {
            this.Id = id;
            this.CustomerId = idCustomer;
            this.BookId = idBook;
            this.SellerId = idSeller;     
        }

        public override string ToString()
        {
            return $"{CustomerId} - {BookId} - {SellerId}";
        }
    }
}
