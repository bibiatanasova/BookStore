using Microsoft.EntityFrameworkCore;
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

        public Customer(int id, string password,string firstName, string lastName, int age)
        {
            this.Id = id;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public int Id { get;  set; }
        public string Password { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public int Age { get;  set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }
    }
}
