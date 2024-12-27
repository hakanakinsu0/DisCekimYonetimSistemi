using Project.CONF.Options;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : DbContext
    {
        public MyContext() : base("WindowsAuthConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AlbumConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new PaymentConfiguration());
            modelBuilder.Configurations.Add(new PhotographerConfiguration());
            modelBuilder.Configurations.Add(new PhotoShootConfiguration());
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Photographer> Photographers { get; set; }
        public DbSet<PhotoShoot> PhotoShoots { get; set; }
    }
}
