using System;
using System.Collections.Generic;

namespace CrmApp
{
    class Basket
    {
        private List<Product> products;
        public Customer Customer { get; set; }

        public Basket()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void Print()
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

        }


        public void ShowCategories()
        {
            int HowManyLow = 0;
            int HowManyMedium = 0;
            int HowManyHigh = 0;

            foreach (Product p in products)
            {
                if (p.GetRange() == "Low") HowManyLow++;
                if (p.GetRange() == "Medium") HowManyMedium++;
                if (p.GetRange() == "High") HowManyHigh++;
            }

            Console.WriteLine($"Low={HowManyLow}");
            Console.WriteLine($"Medium={HowManyMedium}");
            Console.WriteLine($"High={HowManyHigh}");

        }

        public decimal TotalCost()
        {
            decimal totalCost = 0;
            foreach (Product p in products)
            {
                totalCost += p.TotalCost;
            }

            return totalCost;
        }


    }


}



        


       