using DukanTech.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DukanTech.Repository.DbContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext() { }
        public ProductContext(DbContextOptions<ProductContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           if (!options.IsConfigured)
           {
             options.UseSqlServer(@"Data Source=.;Initial Catalog=DukkanTechProductsDB;Integrated Security=True;");
           }
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b34"),
                    BarCode = "Berry1",
                    Description = "Product 1",
                    Weight = "1 kg",
                    Status = 1
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    BarCode = "Berry2",
                    Description = "Product 2",
                    Weight = "2 kg",
                    Status = 2
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b36"),
                    BarCode = "Berry3",
                    Description = "Product 3",
                    Weight = "3 kg",
                    Status = 3
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b37"),
                    BarCode = "Berry4",
                    Description = "Product 4",
                    Weight = "4 kg",
                    Status = 3
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b38"),
                    BarCode = "Berry5",
                    Description = "Product 5",
                    Weight = "5 kg",
                    Status = 2
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b39"),
                    BarCode = "Berry6",
                    Description = "Product 6",
                    Weight = "6 Kg",
                    Status = 2
                },
                new Product()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b40"),
                    BarCode = "Berry7",
                    Description = "Product 7",
                    Weight = "7 kg",
                    Status = 3
                }
                );
        }
        }
}
