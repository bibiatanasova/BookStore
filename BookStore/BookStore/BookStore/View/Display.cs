using BookStore.Controller;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.View
{
    public class Display : StoreController
    {
        Customer customer = new Customer();

        public Display()
        {
            this.LogInMenu();
            Console.Clear();
            this.MainMenu();
        }

        private void LogInMenu()
        {
            Console.WriteLine("Log in menu:");
            Console.WriteLine("1. SingIn");
            Console.WriteLine("2. SingUp");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    this.SingIn();
                    break;
                default:
                    this.SingUp();
                    break;
            }
        }
        private void SingIn()
        {
            Console.Write("Your id: ");
            customer.IdCustomer = int.Parse(Console.ReadLine());
            Console.Write("Rassword: ");
            customer.Password = Console.ReadLine();
        }
        private void SingUp()
        {
            Console.Write("Firt name: ");
            customer.FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            customer.LastName = Console.ReadLine();
            Console.Write("Age: ");
            customer.Age = int.Parse(Console.ReadLine());
            Console.Write("Password: ");
            customer.Password = Console.ReadLine();

            Console.WriteLine("You are successfuly registered!");
            Console.WriteLine($"Your new Id is: {customer.IdCustomer}");
        }

        private void MainMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Create a book");
            Console.WriteLine("2. Update a book");
            Console.WriteLine("3. Delete a book");
            Console.WriteLine("4. Get a book");
            Console.WriteLine("5. Get all books");
            Console.WriteLine("6. LogOut");
            Console.WriteLine("7. Exit and LogOut");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    this.CreateBook();
                    break;
                case 2:
                    this.UpdateBook();
                    break;
                case 3:
                    this.DeleteBook();
                    break;
                case 4:
                    this.GetBook();
                    break;
                case 5:
                    this.GetAll();
                    break;
                case 6:
                    //this.LogOut(); - изчиства се информацията
                    Console.WriteLine("You successfuly logged out!");
                    this.LogInMenu();
                    break;
                default:
                    break;
            }
        }
        private void CreateBook()
        {
            StoreController storeController = new StoreController();

            storeController.CreateBook();
        }
        private void GetAll()
        {
            StoreController storeController = new StoreController();

            storeController.GetAll();
        }
        private void UpdateBook()
        {
            StoreController storeController = new StoreController();

            storeController.UpdateBook();
        }
        private void GetBook()
        {
            StoreController storeController = new StoreController();

            storeController.GetBook();
        }
        private void DeleteBook()
        {
            StoreController storeController = new StoreController();

            storeController.DeleteBook();
        }
    }
}
