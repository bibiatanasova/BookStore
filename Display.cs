using BookStore.Controller;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.View
{
    public class Display
    {
        Customer customer = new Customer();
        Seller seller = new Seller();
        private bool isRunning;
        private BookOperation bookOperation;

        public Display(BookOperation bookOperation)
        {
            this.bookOperation = bookOperation;
            this.isRunning = true;
            this.Run();
        }

        private void MainMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Create a book");
            Console.WriteLine("2. Update a book");
            Console.WriteLine("3. Add Author");
            Console.WriteLine("4. Add Customer");
            Console.WriteLine("5. Add Seller");
            Console.WriteLine("6. Delete a book");
            Console.WriteLine("7. Delete Author");
            Console.WriteLine("8. Delete Customer");
            Console.WriteLine("9. Delete Seller");
            Console.WriteLine("10. Get a book");
            Console.WriteLine("11. Get a author");
            Console.WriteLine("12. Get all books");
            Console.WriteLine("13. Get all authors");
            Console.WriteLine("14. Sell a book");
            Console.WriteLine("15. Exit");
        }

        public void Run()
        {
            while (isRunning)
            {
                MainMenu();
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        this.CreateBook();
                        Console.Clear();
                        break;
                    case 2:
                        this.UpdateBook();
                        Console.Clear();
                        break;
                    case 3:
                        this.AddAuthor();
                        Console.Clear();
                        break;
                    case 4:
                        this.AddCustomer();
                        Console.Clear();
                        break;
                    case 5:
                        this.AddSeller();
                        Console.Clear();
                        break;
                    case 6:
                        this.DeleteBook();
                        Console.Clear();
                        break;
                    case 7:
                        this.DeleteAuthor();
                        Console.Clear();
                        break;
                    case 8:
                        this.DeleteCustomer();
                        Console.Clear();
                        break;
                    case 9:
                        this.DeleteSeller();
                        Console.Clear();
                        break;
                    case 10:
                        this.GetBook();
                        break;
                    case 11:
                        this.GetAuthor();
                        break;
                    case 12:
                        this.GetAllBook();
                        break;
                    case 13:
                        this.GetAllAuthors();
                        break;
                    case 14:
                        this.SellBook();
                        break;
                    case 15:
                        Console.WriteLine("Bye! Have a nice day!");
                        isRunning = false;
                        break;
                    default:
                        break;
                }
                
                      
            }
        }
     
        private void GetAuthor()
        {
            Console.WriteLine("Author id: ");
            int id = int.Parse(Console.ReadLine());

            Author author = this.bookOperation.GetAuthor(id);

            Console.WriteLine(author);
        }

        private void DeleteCustomer()
        {
            Console.WriteLine("Customer ID: ");
            int id = int.Parse(Console.ReadLine());

            this.bookOperation.DeleteCustomer(id);
        }

        private void DeleteSeller()
        {
            Console.WriteLine("Seller ID: ");
            int id = int.Parse(Console.ReadLine());

            this.bookOperation.DeleteSeller(id);
        }

        private void AddCustomer()
        {
            Console.WriteLine("Name: ");
            string[] name = Console.ReadLine().Split(" ");
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());

            Customer customer = new Customer(0, password , name[0] , name[1] , age );
            bookOperation.AddCustomer(customer);
        }

        private void AddSeller()
        {
            Console.WriteLine("Name: ");
            string[] name = Console.ReadLine().Split (" ");

            Seller seller = new Seller(0, name [0], name[1]);
            bookOperation.AddSeller(seller);
        }

        private void AddAuthor()
        {
            Console.WriteLine("Name: ");
            string[] name = Console.ReadLine().Split(" ");
   
            Author author = new Author(0, name[0], name[1]);
            bookOperation.AddAuthor(author);
        }

        private void DeleteAuthor()
        {
            Console.WriteLine("Author ID:");
            int id = int.Parse(Console.ReadLine());

            this.bookOperation.DeleteAuthor(id);
        }

        private void GetAllBook()
        {
            List<Book> books = this.bookOperation.GetAllBooks();

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        private void GetAllAuthors()
        {
            List<Author> authors = this.bookOperation.GetAllAuthors();

            foreach ( var author in authors)
            {
                Console.WriteLine(author);
            }
        }

        private void CreateBook()
        {
            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Genre:");
            string genre = Console.ReadLine();
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Id Author: ");
            int idAuthor = int.Parse(Console.ReadLine());
            Console.WriteLine("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            Book book = new Book(0, title, genre,year, price,idAuthor,stock);
            bookOperation.CreateBook(book);
        }

        private void UpdateBook()
        {
            Console.WriteLine("Book ID:");
            int idBook = int.Parse(Console.ReadLine());

            Console.WriteLine(this.bookOperation.GetBook(idBook));

            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Id Author: ");
            int idAuthor = int.Parse(Console.ReadLine());
            Console.WriteLine("Genre:");
            string genre = Console.ReadLine();
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            Book book = new Book(idBook, title, genre, year, price, idAuthor,stock);

            this.bookOperation.UpdateBook(book);
        }

        private void GetBook()
        {
            Console.WriteLine("Book ID:");
            int id = int.Parse(Console.ReadLine());

            Book book = this.bookOperation.GetBook(id);

            Console.WriteLine(book);
        }

        private void DeleteBook()
        {
            Console.WriteLine("Book ID:");
            int id = int.Parse(Console.ReadLine());

            this.bookOperation.DeleteBook(id);
        }

        private void SellBook()
        {
            Console.WriteLine("Book ID:");
            int idBook = int.Parse(Console.ReadLine());

            Console.WriteLine("Seller ID:");
            int idSeller = int.Parse(Console.ReadLine());

            Console.WriteLine("Customer ID:");
            int idcustomer = int.Parse(Console.ReadLine());

            this.bookOperation.SellBook(idBook, idSeller, idcustomer);
        }
    }
}