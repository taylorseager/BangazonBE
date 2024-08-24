using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;

public class BangazonDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Seller> Sellers { get; set; }

    public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(new Product[]
        {
            new Product
            {
                Id = 1,
                SellerId = 1,
                Title = "Hand Knit Scarf",
                Description = "A cozy, hand-knitted scarf made from 100% organic wool. Perfect for chilly days.",
                QuantityAvailable = 25,
                Price = 45.00M,
                Image = "https://i.ytimg.com/vi/aOPXU_3maSE/sddefault.jpg",
                DateAdded = new DateTime(2024-08-01)
            },
             new Product
            {
                Id = 2,
                SellerId = 1,
                Title = "Homemade Soy Candles",
                Description = "A set of three homemade soy candles with natural scents like lavender, vanilla, and cinnamon.",
                QuantityAvailable = 25,
                 Price = 30.00M,
                Image = "https://i.ebayimg.com/images/g/1yIAAOSwNmJhf4Ch/s-l1200.jpg",
                DateAdded = new DateTime(2024-08-05)
            },
              new Product
            {
                Id = 3,
                SellerId = 1,
                Title = "Wooden Coasters",
                Description = "Set of four handcrafted wooden coasters, made from reclaimed wood. Each coaster is unique.",
                QuantityAvailable = 40,
                Price = 19.99M,
                Image = "https://assets.bigcartel.com/product_images/233112323/coast+1+.jpg?auto=format&fit=max&w=1500",
                DateAdded = new DateTime(2024-08-10)
            },
               new Product
            {
                Id = 4,
                SellerId = 1,
                Title = "Herbal Soap",
                Description = "Organic, homemade herbal soap infused with essential oils. Gentle on skin and eco-friendly.",
                QuantityAvailable = 15,
                Price = 10.00M,
                Image = "https://lovelygreens.com/wp-content/uploads/herbal-soap-calendula.jpg",
                DateAdded = new DateTime(2024-08-12)
            },
                new Product
            {
                Id = 5,
                SellerId = 1,
                Title = "Ceramic Mugs",
                Description = "A pair of hand-painted ceramic mugs with unique designs. Dishwasher and microwave safe.",
                QuantityAvailable = 25,
                Price = 35.00m,
                Image = "https://kariceramics.com/cdn/shop/products/Kari_ceramics_handmade_pottery_all_ceramic_mugs.jpg?v=1625917134",
                DateAdded = new DateTime(2024-08-20)
            }
        });
}