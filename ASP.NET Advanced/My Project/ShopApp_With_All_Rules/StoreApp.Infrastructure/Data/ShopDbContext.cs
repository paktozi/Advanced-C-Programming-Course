using Microsoft.EntityFrameworkCore;
using ShopApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Infrastructure.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WarehouseProduct>().HasKey(wh => new { wh.ProductId, wh.WareHouseId });

            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Shop> Shops { get; set; }

        public virtual DbSet<CashBox> CashBoxes { get; set; }

        public virtual DbSet<Seller> Sellers { get; set; }

        public virtual DbSet<WareHouse> WareHouses { get; set; }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<WarehouseProduct> WarehouseProducts { get; set; }
    }
}
