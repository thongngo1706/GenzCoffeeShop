using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int LocationId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public int? RewardId { get; set; }  // Optional foreign key for reward

        // Navigation properties
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Location Location { get; set; }
        public Reward Reward { get; set; }
    }
}