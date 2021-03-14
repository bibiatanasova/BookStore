using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Author
    {
        private string fristName;
        private string lastName;

        public Author(int idAuthor, string firstName, string lastName)
        {
            this.IdAuthor = idAuthor;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int IdAuthor { get; private set; }
        public string  FirstName 
        {
            get { return fristName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Author first name cannot be null or empty!");
                }
                fristName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Author last name cannot be null or empty!");
                }
            }
        }
    }
}
