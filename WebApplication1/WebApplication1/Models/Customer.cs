using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int LocationId { get; set; }  // Unique identifier for each location
        public string Name { get; set; }  // Name of the coffee shop location
        public string Address { get; set; }  // Address of the coffee shop
        public ICollection<Order> Orders { get; set; }  // List of orders for this location
    }
}