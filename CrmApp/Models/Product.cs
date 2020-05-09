using CrmApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CrmApp
{
    public class Product
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public decimal Price { get; set; }       
        public int Quantity { get; set; }
        public List<BasketProduct> BasketProducts { get; set; }
        public decimal TotalCost { get { return Price * Quantity; } }
                   
    }

}
