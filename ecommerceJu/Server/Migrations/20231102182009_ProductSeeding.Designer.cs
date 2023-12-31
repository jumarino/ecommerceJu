﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerceJu.Server.Data;

#nullable disable

namespace ecommerceJu.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231102182009_ProductSeeding")]
    partial class ProductSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ecommerceJu.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Nespresso capsules were sold exclusively by Nespresso while the machines were under patent, and are significantly more expensive than an equivalent quantity of loose ground coffee.",
                            ImageUrl = "",
                            Price = 19.99m,
                            Title = "Nespresso"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Nescafé Dolce Gusto coffee capsules come in a variety of pack sizes which contain 12, 16 or 30 capsules. 12 pod boxes can make between 6 – 12 cups and 30 pod boxes are sufficient enough for between 15 – 30 cups, depending on the type of beverage.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ab/Logo_Nescaf%C3%A9_dolce_gusto.png",
                            Price = 29.99m,
                            Title = "Dolce Gusto"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Starbucks Verismo became publicly available, consisting of a line of coffee makers that brew espresso and regular chocolate from coffee capsules, a type of pre-apportioned single-use container of ground coffee and flavourings utilizing the K-Fee pod system.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/0/0f/Starbucks_Corporation_Logo_2011.svg.png",
                            Price = 39.99m,
                            Title = "Starbucks"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
