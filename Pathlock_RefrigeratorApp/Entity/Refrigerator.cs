using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pathlock_RefrigeratorApp.Entity
{
    public class Refrigerator
    {
        private List<Product> products = new List<Product>();

        //insert a product
        public void InsertProduct(string name, double quantity, DateTime expiryDate)
        {
            products.Add(new Product(name, quantity, expiryDate));
            Console.WriteLine("Product added successfully!!");
        }

        //consume the product
        public void ConsumeProduct(string name, double consumedQuantity)
        {
            Product product = products.FirstOrDefault(p => p.Name.Trim().ToLower() == name.Trim().ToLower());
            if (product != null)
            {
                if (consumedQuantity <= product.Quantity)
                {
                    product.Quantity -= consumedQuantity;
                    Console.WriteLine($"{consumedQuantity} units of {name} consumed.");
                }
                else
                {
                    Console.WriteLine("Insufficient quantity.");
                }
            }
            else
            {
                Console.WriteLine($"Product {name} not found.");
            }
        }

        //display the current status, items count 
        public void ShowCurrentStatus()
        {
            Console.WriteLine("Current status:");
            if(products == null || products.Count == 0)
                Console.WriteLine("Refrigerator is empty, You can add product by chooseing 1.");

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Quantity} units (Expires on: {product.ExpiryDate})");
            }
        }

        //display the expired products
        public void CheckExpiredProducts()
        {
            DateTime currentDate = DateTime.Now;
            List<Product> expiredProducts = products.Where(p => p.ExpiryDate <= currentDate).ToList();
            if(expiredProducts == null || expiredProducts.Count() == 0)
                Console.WriteLine("Yey!!, No item is expired.");

            foreach (Product product in expiredProducts)
            {
                Console.WriteLine($"Alert: {product.Name} has expired. Remove from the refrigerator.");
                products.Remove(product);
            }
        }
    }
}
