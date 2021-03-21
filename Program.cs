using BookStore.Controller;
using BookStore.Models;
using BookStore.View;
using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DataConnection dataConnection = new DataConnection();
            BookOperation bookOperation = new BookOperation(dataConnection);
            Display display = new Display(bookOperation);
        }
    }
}
