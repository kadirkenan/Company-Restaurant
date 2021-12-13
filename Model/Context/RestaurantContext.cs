using DataAccess.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class RestaurantContext:IdentityDbContext<AppUser>
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {

        }
       public DbSet<Employee> Employees { get; set; }
       public DbSet<MenuProduct> MenuProducts { get; set; }
       public DbSet<Supplier> Suppliers { get; set; }
       public DbSet<StorageProduct> StorageProducts { get; set; }
       public DbSet<CustomerOrder> CustomerOrders { get; set; }
       public DbSet<MenuCategory> MenuCategories { get; set; }
       public DbSet<Prescription>  Prescriptions  { get; set; }
       public DbSet<StorageCategory>   StorageCategories  { get; set; }
       public DbSet<Table> Tables  { get; set; }
       public DbSet<Gauge> Gauges { get; set; }
        public DbSet<PrescriptionIngrident> PrescriptionIngridents { get; set; }
        public DbSet<TableMenu> TableMenus { get; set; }
        public DbSet<PrescriptionGauge> PrescriptionGauges { get; set; }
        public DbSet<PrescriptionStorageProduct> PrescriptionStorageProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
