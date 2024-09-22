using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string CustomerAddress { get; set; }
        public int Reward { get; set; }

        // Navigation property for Orders
        public virtual ICollection<Order> Orders { get; set; }
    }
}
