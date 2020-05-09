using CrmApp.Models;
using CrmApp.Options;
using CrmApp.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrmApp.Services
{
    public class BasketManagement
    {
        private CrmDbContext db;
        public BasketManagement(CrmDbContext _db)
        {
            db = _db;
        }
        public Basket CreateBasket(BasketOption baskOption)
        {
            CustomerManagement cstMng = new CustomerManagement(db);
            Basket basket = new Basket
            {
                Customer = cstMng.FindCustomerById(baskOption.CustomerId)

            };

            db.Baskets.Add(basket);
            db.SaveChanges();
            return basket;

        }

        public BasketProduct AddProduct(BasketProductOption bskProd)
        {
            CustomerManagement cstMng = new CustomerManagement(db);
            BasketProduct basketProduct = new BasketProduct
            {
                Basket=db.Baskets.Find(bskProd.BasketId),
                Product=db.Products.Find(bskProd.ProductId)

            };

            db.BasketProducts.Add(basketProduct);
            db.SaveChanges();
            return basketProduct;

        }

        public Basket FindBasketById(int basketId)
        {
            return db.Baskets.Include(basket => basket.Customer).Where(basket => basket.Id == basketId).First();
                      
        }

        public List<Basket> FindCustomerBaskets(int custId)
        {
            return db.Baskets
            
            .Where(basket => basket.Customer.Id == custId).ToList();
            
        }

        public bool RemoveProduct(BasketProductOption bskProdOpt)
        {
            BasketProduct bskProd = db.BasketProducts.Find(bskProdOpt);

            if (bskProd != null)
            {
                db.BasketProducts.Remove(bskProd);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        internal Basket CreateBasket(object baskOption)
        {
            throw new NotImplementedException();
        }
    }
}
