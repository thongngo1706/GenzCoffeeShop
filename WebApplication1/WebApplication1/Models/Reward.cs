using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Reward
    {
        public int RewardId { get; set; }
        public string Description { get; set; }
        public int PointsRequired { get; set; }

        // Navigation property for Orders (optional)
        public ICollection<Order> Orders { get; set; }
    }
}