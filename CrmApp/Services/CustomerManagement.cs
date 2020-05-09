using CrmApp.Options;
using CrmApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmApp.Services
{
    public class CustomerManagement 
    {
        private CrmDbContext db;

        public CustomerManagement (CrmDbContext _db)
        {
            db = _db;
        }

        public Customer CreateCustomer(CustomerOption custOption)
        {
            Customer customer = new Customer
            {
                FirstName = custOption.FirstName,
                LastName = custOption.LastName,
                Adress = custOption.Adress,
                Dob = custOption.Dob,
                Email = custOption.Email,
                Active = true,
                Balance = 0
            };

            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;

        }

        public  Customer FindCustomerById(int id)
        {
            
            return db.Customers.Find(id);
        }

        public List<Customer> FindCustomerByName(CustomerOption custOption)
        {
            return db.Customers
            .Where(cust => cust.LastName==custOption.LastName).ToList() 
            .Where(cust => cust.FirstName == custOption.FirstName).ToList()
            .ToList();

        }

        public Customer Update(CustomerOption custOption, int customerId)
        {
            Customer customer = db.Customers.Find(customerId);

            if (custOption.FirstName != null)
                customer.FirstName = custOption.FirstName;

            if (custOption.LastName != null)
                customer.LastName = custOption.LastName;

            if (custOption.Email != null)
                customer.Email = custOption.Email;

            if (custOption.Dob != null)
                customer.Dob = custOption.Dob;

            db.SaveChanges();
            return customer;

        }

        public bool DeleteCustomerById(int id)
        {
            Customer customer = db.Customers.Find(id);

            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool SoftDeleteCustomerById(int id)
        {
            Customer customer = db.Customers.Find(id);

            if (customer != null)
            {
                customer.Active = false;
                db.SaveChanges();
                return true;
            }

            return false;

        }

            public List<Customer> GetAllCustomers()
            {
            return db.Customers.ToList();
             }
    
    }
}
