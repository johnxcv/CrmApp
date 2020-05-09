using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CrmApp
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }      
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public bool Active { get; set; }
        public decimal Balance { get; set; }   
        public List<Basket> Baskets { get; set; }
              
    }
  
}
