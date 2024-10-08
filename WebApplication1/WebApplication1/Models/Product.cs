﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        // Navigation property
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }

}