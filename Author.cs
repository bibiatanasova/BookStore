using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models
{
    public class Author
    {
        public Author(int idAuthor, string firstName, string lastName)
        {
            this.IdAuthor = idAuthor;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int IdAuthor { get; private set; }
        public string  FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
