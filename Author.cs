
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Models
{
    public class Author
    {
        public Author(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Author()
        {

        }   
       
        public int Id { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }

        public override string ToString()
        {
            return $"Id:{Id} - {FirstName} {LastName}";
        }
    }
}
