using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;

public class BangazonDbContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Seller> Sellers { get; set; }

    public BangazonDbContext(DbContextOptions<BangazonDbContext> context) : base(context)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User[]
       {
           new User
           {
               Id = "1",
               Image = "",
               Seller = false
           }

       });

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
                DateAdded = new DateTime(2024 - 08 - 01)
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
                DateAdded = new DateTime(2024 - 08 - 05)
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
                DateAdded = new DateTime(2024 - 08 - 10)
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
                DateAdded = new DateTime(2024 - 08 - 12)
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
                DateAdded = new DateTime(2024 - 08 - 20)
            },
            new Product
            {
                Id = 6,
                SellerId = 1,
                Title = "Handcrafted Wooden Bowl",
                Description = "A beautifully handcrafted wooden bowl made from reclaimed oak wood. Perfect for serving salads or as a decorative piece.",
                QuantityAvailable = 12,
                Price = 35.99m,
                Image = "https://m.media-amazon.com/images/I/71A6SYOZwVL._AC_UF894,1000_QL80_.jpg",
                DateAdded = new DateTime(2024, 8, 26)
            },
            new Product
            {
                Id = 7,
                SellerId = 1,
                Title = "Handmade Beaded Dog Collar",
                Description = "Handcrafted beaded dog collar made with durable leather and colorful, intricate beadwork. A unique accessory that adds style and comfort for your furry friend.",
                QuantityAvailable = 20,
                Price = 24.99m,
                Image = "https://swdistinctions.com/wp-content/uploads/2016/06/sw-mountain-collar-unnamed.png",
                DateAdded = new DateTime(2024, 7, 15)
            },
            new Product
            {
                Id = 8,
                SellerId = 1,
                Title = "Ceramic Coffee Mug",
                Description = "A unique ceramic coffee mug, handcrafted and glazed in vibrant colors. Dishwasher and microwave safe.",
                QuantityAvailable = 30,
                Price = 18.50m,
                Image = "https://stellancworks.com/cdn/shop/products/20220406_125939_1024x1024@2x.jpg?v=1652184454",
                DateAdded = new DateTime(2024, 6, 10)
            },
            new Product
            {
                Id = 9,
                SellerId = 1,
                Title = "Leather Journal",
                Description = "Handmade leather-bound journal with recycled paper. Perfect for writing, sketching, or as a diary.",
                QuantityAvailable = 15,
                Price = 45.00m,
                Image = "https://www.galenleather.com/cdn/shop/products/refillable-leather-wrap-journal-planner-cover-crazy-horse-brown_2000x.jpg?v=1622296261",
                DateAdded = new DateTime(2024, 5, 5)
            },
            new Product
            {
                Id = 10,
                SellerId = 1,
                Title = "Recycled Glass Vase",
                Description = "An elegant vase made from recycled glass, with a unique texture and shape. A great centerpiece for any room.",
                QuantityAvailable = 8,
                Price = 32.75m,
                Image = "https://i.ebayimg.com/images/g/FaUAAOSwcQdjka-Z/s-l400.jpg",
                DateAdded = new DateTime(2024, 4, 25)
            },
            new Product
            {
                Id = 11,
                SellerId = 1,
                Title = "Bamboo Cutting Board",
                Description = "Durable and eco-friendly, this bamboo cutting board is handmade and treated with natural oils for a long-lasting finish.",
                QuantityAvailable = 25,
                Price = 27.99m,
                Image = "https://m.media-amazon.com/images/I/A16Lps3fycL._UF1000,1000_QL80_.jpg",
                DateAdded = new DateTime(2024, 3, 19)
            },
            new Product
            {
                Id = 12,
                SellerId = 1,
                Title = "Hand-Painted Silk Scarf",
                Description = "A luxurious hand-painted silk scarf with floral motifs. Lightweight and perfect for all seasons.",
                QuantityAvailable = 10,
                Price = 65.00m,
                Image = "https://invisibleworld.com/cdn/shop/products/invisible-world-long-hand-painted-silk-scarf-monochrome-flowers-29200750608453_813x.jpg?v=1629674715",
                DateAdded = new DateTime(2024, 2, 8)
            },
            new Product
            {
                Id = 13,
                SellerId = 1,
                Title = "Natural Soy Wax Candle",
                Description = "Hand-poured soy wax candle with a refreshing lavender scent. Burns cleanly and lasts up to 40 hours.",
                QuantityAvailable = 40,
                Price = 15.50m,
                Image = "https://i5.walmartimages.com/asr/85ea12b1-ecb7-431e-bb11-bfa665a31981.a444b21c5cc1654ad3b0f3fcb87b816f.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF",
                DateAdded = new DateTime(2024, 1, 14)
            },
            new Product
            {
                Id = 14,
                SellerId = 1,
                Title = "Macramé Wall Hanging",
                Description = "A boho-inspired macramé wall hanging, hand-knotted with natural cotton rope. Adds a rustic touch to any home decor.",
                QuantityAvailable = 7,
                Price = 55.00m,
                Image = "https://m.media-amazon.com/images/I/91IQzXWHmQL.jpg",
                DateAdded = new DateTime(2024, 8, 1)
            },
            new Product
            {
                Id = 15,
                SellerId = 1,
                Title = "Hand-Carved Wooden Spoon Set",
                Description = "Set of three hand-carved wooden spoons made from sustainably sourced walnut wood. Perfect for cooking and serving.",
                QuantityAvailable = 16,
                Price = 30.00m,
                Image = "https://images.squarespace-cdn.com/content/v1/5cb5bc4b7fdcb821197daa93/1676901378771-2J0XFNJ49RX8PL7XG1NB/Spoon+Set+with+Spoon+Rack2.jpeg?format=2500w",
                DateAdded = new DateTime(2024, 7, 27)
            }
        });

        modelBuilder.Entity<Order>().HasData(new Order[]
         {
               new Order
               {
                   Id = 1,
                   UserId = "1",
               },
                  new Order
               {
                   Id = 2,
                   UserId = "1",
               },
                  new Order
               {
                   Id = 3,
                   UserId = "1",
               }

         });
    }
}