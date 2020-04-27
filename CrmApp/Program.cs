using System;
using System.Collections.Generic;

namespace CrmApp
{
    public class AnotherClass
    {
        static void Main()
        {
            UI ui = new UI();

            Product myProduct = ui.CreateProduct();
            if (myProduct != null)
            {
                myProduct.Print();




                decimal total = myProduct.TotalCost;
                Console.WriteLine(total);

            }


            Product myProduct1 = ui.CreateProduct();
            Product myProduct2= ui.CreateProduct();

            Customer myCustomer = ui.CreateCustomer();

            if (myCustomer != null)
            {
                myCustomer.Print();

            }

            List<Product> products = new List<Product>
            {
                myProduct,
                myProduct1,
                myProduct2
            };

            int HowManyHi = 0;
            int HowManyMedium = 0;
            int HowManyLow = 0;
            foreach (Product p in products)
            {

                Console.WriteLine(p.GetRange());
                if (p.GetRange() == "Hi") HowManyHi++;
                if (p.GetRange() == "Medium") HowManyMedium++;
                if (p.GetRange() == "Low") HowManyLow++;
            }

            Console.WriteLine($"HowManyHi={HowManyHi}" );
            Console.WriteLine($"HowManyMedium={HowManyMedium}");
            Console.WriteLine($"HowManyLow={HowManyLow}");



            for (int i=0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
            }

            

        } 

        

    }
}
