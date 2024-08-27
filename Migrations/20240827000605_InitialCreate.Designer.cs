﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEnd.Migrations
{
    [DbContext(typeof(BangazonDbContext))]
    [Migration("20240827000605_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BackEnd.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("BackEnd.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BackEnd.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("integer");

                    b.Property<int>("SellerId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2015),
                            Description = "A cozy, hand-knitted scarf made from 100% organic wool. Perfect for chilly days.",
                            Image = "https://i.ytimg.com/vi/aOPXU_3maSE/sddefault.jpg",
                            Price = 45.00m,
                            QuantityAvailable = 25,
                            SellerId = 1,
                            Title = "Hand Knit Scarf"
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2011),
                            Description = "A set of three homemade soy candles with natural scents like lavender, vanilla, and cinnamon.",
                            Image = "https://i.ebayimg.com/images/g/1yIAAOSwNmJhf4Ch/s-l1200.jpg",
                            Price = 30.00m,
                            QuantityAvailable = 25,
                            SellerId = 1,
                            Title = "Homemade Soy Candles"
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2006),
                            Description = "Set of four handcrafted wooden coasters, made from reclaimed wood. Each coaster is unique.",
                            Image = "https://assets.bigcartel.com/product_images/233112323/coast+1+.jpg?auto=format&fit=max&w=1500",
                            Price = 19.99m,
                            QuantityAvailable = 40,
                            SellerId = 1,
                            Title = "Wooden Coasters"
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2004),
                            Description = "Organic, homemade herbal soap infused with essential oils. Gentle on skin and eco-friendly.",
                            Image = "https://lovelygreens.com/wp-content/uploads/herbal-soap-calendula.jpg",
                            Price = 10.00m,
                            QuantityAvailable = 15,
                            SellerId = 1,
                            Title = "Herbal Soap"
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996),
                            Description = "A pair of hand-painted ceramic mugs with unique designs. Dishwasher and microwave safe.",
                            Image = "https://kariceramics.com/cdn/shop/products/Kari_ceramics_handmade_pottery_all_ceramic_mugs.jpg?v=1625917134",
                            Price = 35.00m,
                            QuantityAvailable = 25,
                            SellerId = 1,
                            Title = "Ceramic Mugs"
                        });
                });

            modelBuilder.Entity("BackEnd.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("StoreDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("BackEnd.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Seller")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Image = "",
                            Seller = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
