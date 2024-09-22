using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        public string StoreLocation { get; set; }
        public string Event { get; set; }

        // Navigation property
        public virtual ICollection<Order> Orders { get; set; }
    }

}