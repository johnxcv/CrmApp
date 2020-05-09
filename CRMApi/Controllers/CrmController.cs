using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrmApp;
using CrmApp.Options;
using CrmApp.Repository;
using CrmApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CRMApi.Controllers
{
    [ApiController]
    [Route("[controller]/customer")]
    public class CrmController : ControllerBase
    {

        private readonly ILogger<CrmController> _logger;

        public CrmController(ILogger<CrmController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public string Get()
        {
           
            return "Welcome to our site";
        }

  

        [HttpGet("all")]

        public List<Customer> GetAllCustomer()
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return db.Customers.ToList();

        }


        [HttpGet("{id}")]
        public List<Customer> GetAllCustomers(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.GetAllCustomers();
       
        }

        [HttpPost("")]
        public Customer PostCustomer(CustomerOption custOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.CreateCustomer(custOpt);
        }

        [HttpPut("{id}")]
        public Customer PutCustomer(int id, CustomerOption custOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.Update(custOpt, id);
        }

        [HttpDelete("hard/{id}")]
        public bool HardDeleteCustomer(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.DeleteCustomerById(id);
        }


        [HttpDelete("soft/{id}")]
        public bool SoftDeleteCustomer(int id, CustomerOption custOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            CustomerManagement custMangr = new CustomerManagement(db);
            return custMangr.SoftDeleteCustomerById(id);
        }

        [HttpGet("all")]

        public List<Product> GetAllProduct()
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMangr = new ProductManagement(db);
            return db.Products.ToList();

        }

        [HttpGet("id")]

        public List<Product> GetAllProducts(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMangr = new ProductManagement(db);
            return prodMangr.GetAllProducts();

        }

        [HttpPost("")]
        public Product PostProduct(ProductOption prodOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMangr = new ProductManagement(db);
            return prodMangr.CreateProduct(prodOpt);
        }

        [HttpPut("{id}")]
        public Product PutProduct(int id, ProductOption prodOpt)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMangr = new ProductManagement(db);
            return prodMangr.Update(prodOpt, id);
        }

        [HttpDelete("hard/{id}")]
        public bool HardDeleteProduct(int id)
        {
            using CrmDbContext db = new CrmDbContext();
            ProductManagement prodMangr = new ProductManagement(db);
            return prodMangr.DeleteProductById(id);
        }
        
    }
}
