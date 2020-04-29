using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CrmApp
{

    class UI

    {
        public Product CreateProduct()
        {
            Product product = new Product();

            try
            {
                Console.WriteLine("Gve the code ");
                product.Code = Console.ReadLine();
                Console.WriteLine("Gve the Name ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Gve the price ");
                product.Price = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Gve the quantity ");
                product.Quantity = Int32.Parse(Console.ReadLine());

                return product;
            }

            catch (Exception)
            {

                Console.WriteLine("Wrong input." + "Try again.");
                return null;
            }
        }

        public int Menu()
        {
            Console.WriteLine("1. Add product 2. Display Basket " + "3. Show Categories 4.TotalCost 0. Exit");
            Console.WriteLine("Give you choice ");
            int choice = 0;
            try
            {
                choice = Int32.Parse(Console.ReadLine());
            }

            catch (Exception)
            {

            }

            return choice;

        }

        
        public Customer CreateCustomer()
        {
            Customer customer = new Customer();

            try
            {
                Console.WriteLine("Give the name ");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Give the gender ");
                customer.Gender = Console.ReadLine();
                Console.WriteLine("Give the age ");
                customer.Age = Int32.Parse(Console.ReadLine());
                

                return customer;
            }

            catch (Exception)
            {

                Console.WriteLine("Wrong input." + "Try again.");
                return null;
            }


        }

        public int Menu2()
        {
            Console.WriteLine("1. Add customer 2. Display Customer " + "3. Show Demographics ");
            Console.WriteLine("Give you choice ");
            int choice = 0;
            try
            {
                choice = Int32.Parse(Console.ReadLine());
            }

            catch (Exception)
            {

            }

            return choice;

        }

        public Basket CreateBasket()
        {
            Basket basket = new Basket();
            int choice;

            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Product product = CreateProduct();
                        basket.AddProduct(product);
                        break;

                    case 2:
                        basket.Print();
                        break;

                    case 3:
                        basket.ShowCategories();
                        break;

                    case 4:
                        Console.WriteLine("TotalCost= " + basket.TotalCost());
                        break;

                    case 0:
                        Console.WriteLine("You select to exit ");
                        break;

                }
            }

            while (choice != 0);
            return basket;

        }

        public Crowd CreateCrowd()
        {
            Crowd crowd = new Crowd();
            int choice;

            do
            {
                choice = Menu2();
                switch (choice)
                {
                    case 1:
                        Customer customer = CreateCustomer();
                        crowd.AddCustomer(customer);
                        break;

                    case 2:
                        crowd.Print();
                        break;

                    case 3:
                        crowd.ShowDemographics();
                        break;

                   

                    case 0:
                        Console.WriteLine("You select to exit ");
                        break;

                }
            }

            while (choice != 0);
            return crowd;

        }
    }
}

    
      
       
