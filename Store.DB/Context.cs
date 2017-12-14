using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.Common;

namespace Store.DB
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Discount> Discrounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public Context() : base() { }
        public Context(DbConnection existingConnection, bool contextOwnsConnection)
            :base(existingConnection, contextOwnsConnection)
        {
            Database.SetInitializer<Context>(null);

        }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
