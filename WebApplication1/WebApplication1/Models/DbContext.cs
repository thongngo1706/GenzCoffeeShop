using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data.Entity;


namespace WebApplication1.Models
{
    public class CoffeeShopContext : DbContext
    {
        public CoffeeShopContext() : base("name=CoffeeShopContext")
        {
        }

        // DbSets for your models
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }


}
