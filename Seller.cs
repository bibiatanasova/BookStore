using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Seller
    {
        public Seller(int idSeller, string firsName, string lastName)
        {
            this.IdSeller = idSeller;
            this.FirstName = firsName;
            this.LastName = lastName;
        }

        public int IdSeller { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

    }
}
