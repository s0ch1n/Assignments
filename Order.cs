using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment6th2B
{
    // Order class
    class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalAmount => Quantity * Rate;

        public override string ToString()
        {
            return $"Order ID: {OrderId}, Date: {Date.ToShortDateString()}, Customer ID: {CustomerId}, Product ID: {ProductId}, " +
                   $"Product Name: {ProductName}, Quantity: {Quantity}, Rate: {Rate:C}, Total: {TotalAmount:C}";
        }
    }
}
