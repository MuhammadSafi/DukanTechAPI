﻿// <auto-generated />
using System;
using DukanTech.Repository.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DukanTech.Repository.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DukanTech.Repository.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b34"),
                            BarCode = "Berry1",
                            Description = "Product 1",
                            Status = 1,
                            Weight = "1 kg"
                        },
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            BarCode = "Berry2",
                            Description = "Product 2",
                            Status = 2,
                            Weight = "2 kg"
                        },
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b36"),
                            BarCode = "Berry3",
                            Description = "Product 3",
                            Status = 3,
                            Weight = "3 kg"
                        },
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b37"),
                            BarCode = "Berry4",
                            Description = "Product 4",
                            Status = 3,
                            Weight = "4 kg"
                        },
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b38"),
                            BarCode = "Berry5",
                            Description = "Product 5",
                            Status = 2,
                            Weight = "5 kg"
                        },
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b39"),
                            BarCode = "Berry6",
                            Description = "Product 6",
                            Status = 2,
                            Weight = "6 Kg"
                        },
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b40"),
                            BarCode = "Berry7",
                            Description = "Product 7",
                            Status = 3,
                            Weight = "7 kg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
