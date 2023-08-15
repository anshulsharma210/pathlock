using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathlock_RefrigeratorApp.Entity
{
    public class Product
    {
        public string Name { get; }
        public double Quantity { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Product(string name, double quantity, DateTime expiryDate)
        {
            Name = name;
            Quantity = quantity;
            ExpiryDate = expiryDate;
        }
    }
}
