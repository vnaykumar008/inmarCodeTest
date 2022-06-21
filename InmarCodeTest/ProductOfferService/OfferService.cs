using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductOfferService.Models;

namespace ProductOfferService
{
    public class OfferService
    {
        private List<Product> inventory;

        public OfferService()
        {
            inventory = GetInventory();
        }

        public List<Product> GetAllProducts()
        {
            return inventory;
        }

        public Dictionary<string, List<Product>> GetTodaysOffers()
        {
            Random randomNum = new Random();
            var offers = new Dictionary<string, List<Product>>();

            for(int i=0;i<4; i++)
            {
                offers.Add("ComboPackage"+i, new List<Product>() { 
                    inventory[randomNum.Next(6) - 1], 
                    inventory[randomNum.Next(6) - 1], 
                    inventory[randomNum.Next(6) - 1] });
            }
            return offers;
        }

        public void AddProduct(Product product)
        {
            inventory.Add(product);
        }

        private List<Product> GetInventory()
        {
            return new List<Product>() {
                new Product() { ProductName="P1", Price=100, Description="P1 desc"},
                new Product() { ProductName="P2", Price=200, Description="P2 desc"},
                new Product() { ProductName="P3", Price=400, Description="P3 desc"},
                new Product() { ProductName="P4", Price=700, Description="P4 desc"},
                new Product() { ProductName="P5", Price=600, Description="P5 desc"},
                new Product() { ProductName="P6", Price=800, Description="P6 desc"}
            };
        }
    }
}
