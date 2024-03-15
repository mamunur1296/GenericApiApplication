using Api.BOL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DAL.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<DeliveryAddress> DeliveryAddresses { get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProdReturn> ProdReturn { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Retailer> Retailers { get; set;}
        public DbSet<Trader> Traders { get; set; }
        public DbSet<Valve> valves { get; set; }
    }
}
