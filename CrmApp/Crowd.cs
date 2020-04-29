using System;
using System.Collections.Generic;
using System.Text;

namespace CrmApp
{
    class Crowd
    {
        private List<Customer> customers;
        public Customer Customer { get; set; }

        public Crowd()
        {
            customers = new List<Customer>();
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void Print()
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine(c);
            }

        }

        public void ShowDemographics()
        {
            int HowManyTeenagers = 0;
            int HowManyAdults = 0;


            foreach (Customer c in customers)
            {
                if (c.GetRange2() == "Teenagers") HowManyTeenagers++;
                if (c.GetRange2() == "Adutls") HowManyAdults++;

            }

            Console.WriteLine($"Teenagers={HowManyTeenagers}");
            Console.WriteLine($"Adults={HowManyAdults}");


        }
    }
}
