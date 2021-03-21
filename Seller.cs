using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Seller
    {
       

        public Seller()
        {

        }

        public Seller(int id, string firsName, string lastName)
        {
            this.Id = id;
            this.FirstName = firsName;
            this.LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }

    }
}
