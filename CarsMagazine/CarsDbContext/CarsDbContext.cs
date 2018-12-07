using CarsDbContext.Management.Configurations;
using CarsDbContext.Management.DbModels;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace CarsDbContext.Management
{
    public class CarsDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<BrandsModels> BrandsModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var brandsModels = new BrandsModelsConfiguration();
            brandsModels.Configure();
            modelBuilder.Configurations.Add(new BrandsModels())
            modelBuilder.Entity<Brand>().ToTable();
            modelBuilder.Entity<Model>().ToTable();

            modelBuilder.Entity<Brand>().Map(m =>
           {
               m.Properties(p => new { p.ID });
               m.ToTable();
           });

            modelBuilder.Entity<Model>().Map(m =>
           {
               m.Properties(prop => prop.ID);
               m.ToTable();
           });

            base.OnModelCreating(modelBuilder);
        }
    }
}
