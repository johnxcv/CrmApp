using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CrmApp
{
    class UI
    {

        public Product CreateProduct()
        {
            try
            {
                Product product = new Product();
                Console.WriteLine("Give the code ");
                product.Code = Console.ReadLine();
                Console.WriteLine("Give the name ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Give the price ");
                product.Price = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Give the quantity ");
                product.Quantity = Int32.Parse(Console.ReadLine());


                return product;

            }

            catch (Exception)

            {
                Console.WriteLine("Wrong input." +
                    " Try again.");
                return null;

            }


        }

        public Customer CreateCustomer()
        {
            try
            {
                Customer customer = new Customer();
                Console.WriteLine("Give the Name ");
                customer.Name = Console.ReadLine();
                Console.WriteLine("Give the Gender ");
                customer.Gender = Console.ReadLine();
                Console.WriteLine("Give the Age ");
                customer.Age = int.Parse(Console.ReadLine());

                return customer;

            }

            catch (Exception)

            {
                Console.WriteLine("Wrong input." +
                    " Try again.");
                return null;

            }
        }
    }
}
