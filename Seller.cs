using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Seller
    {
        private string firstName;
        private string lastName;

        public Seller()
        {

        }

        public Seller(int idSeller, string firsName, string lastName)
        {
            this.IdSeller = idSeller;
            this.FirstName = firsName;
            this.LastName = lastName;
        }

        public int IdSeller { get; set; }
        public string FirstName 
        {
            get { return firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Seller first name cannot be null or empty!");
                }
                firstName = value;
            }
        }
        public string LastName 
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Seller last name cannot be null or empty!");
                }
            }
        }

    }
}
