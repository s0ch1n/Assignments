using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment6th2B
{
    class Inventory
    {
        private readonly Dictionary<string, (string productName, decimal rate)> _products;

        public Inventory()
        {
            _products = new Dictionary<string, (string, decimal)>
            {
                { "001", ("Laptop", 800.00m) },
                { "002", ("Smartphone", 500.00m) },
                { "003", ("Tablet", 300.00m) },
                { "004", ("Headphones", 50.00m) },
                { "005", ("Keyboard", 20.00m) }
            };
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\nAvailable Products:");
            Console.WriteLine("Product ID | Product Name | Rate");
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Key} | {product.Value.productName} | {product.Value.rate:C}");
            }
        }

        public bool IsValidProduct(string productId)
        {
            return _products.ContainsKey(productId);
        }

        public (string productName, decimal rate) GetProductDetails(string productId)
        {
            return _products[productId];
        }
    }
}
