using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int idCustomer)
        {
            this.IdCustomer = idCustomer;
        }

        public int IdCustomer { get; private set; }
    }
}
