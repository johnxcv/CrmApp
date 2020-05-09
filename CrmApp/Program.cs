using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrmApp
{
    class Program
    {
        static void Main()
        {
            using CrmDbContext db = new CrmDbContext();
            BasketManagement baskMangr = new BasketManagement(db);

            Basket basket = baskMangr.FindBasketById(1);

            basket.BasketProducts.ForEach(baskproduct =>
            Console.WriteLine(db.BasketProducts.Include(b => b.Product).Where(b => b.Id == baskproduct.Id).First().Product.Name));
            
        }
            
        static void Main2()
        {

            CustomerOption custOpt = new CustomerOption
            {
                FirstName = "John",
                LastName = "XCV",
                Adress = "Thessaloniki",
                Email = "john@gmail.com",

            };

            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMngr = new CustomerManagement(db);

            Customer customer = custMngr.CreateCustomer(custOpt);
            Console.WriteLine($"Id={customer.Id} Name={customer.FirstName} Adress={customer.Adress}");

            Customer cx = custMngr.FindCustomerById(2);
            Console.WriteLine($"Id={cx.Id} Name={cx.FirstName} Adress={cx.Adress}");

            CustomerOption custChangingAdress = new CustomerOption
            {
                Adress = "Lamia"
            };

            Customer c2 = custMngr.Update(custChangingAdress, 1);
            Console.WriteLine($"Id={c2.Id} Name={c2.FirstName} Adress={c2.Adress}");

            bool result = custMngr.DeleteCustomerById(2);
            Console.WriteLine($"Result={result}");
            Customer cx2 = custMngr.FindCustomerById(2);

            if (cx2 != null)
            {
                Console.WriteLine($"Id={cx2.Id} Name={cx2.FirstName} Adress={cx2.Adress}");
            }

            else
            {
                Console.WriteLine("Not found");
            }

            ProductOption prOpt = new ProductOption
            {
                Name = "apples", Price = 1.20m, Quantity = 10
            };

            ProductManagement prodMngr = new ProductManagement(db);

            Product product = prodMngr.CreateProduct(prOpt);

            BasketManagement baskMngr = new BasketManagement(db);

            BasketOption baskOption = new BasketOption
            {
                CustomerId=3
            };

            Basket basket = baskMngr.CreateBasket(baskOption);
            BasketProductOption bskProdOpt = new BasketProductOption
            {
                BasketId = basket.Id,
                ProductId = 1
            };

            BasketProduct baskProd = baskMngr.AddProduct(bskProdOpt);

            basket.BasketProducts.ForEach(p=>
            Console.WriteLine(p.Product));

        }
     
    }
}
