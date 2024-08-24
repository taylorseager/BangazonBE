using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StoreName = table.Column<string>(type: "text", nullable: false),
                    StoreDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Seller = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateAdded", "Description", "Image", "Price", "QuantityAvailable", "SellerId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2015), "A cozy, hand-knitted scarf made from 100% organic wool. Perfect for chilly days.", "https://i.ytimg.com/vi/aOPXU_3maSE/sddefault.jpg", 45.00m, 25, 1, "Hand Knit Scarf" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2011), "A set of three homemade soy candles with natural scents like lavender, vanilla, and cinnamon.", "https://i.ebayimg.com/images/g/1yIAAOSwNmJhf4Ch/s-l1200.jpg", 30.00m, 25, 1, "Homemade Soy Candles" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2006), "Set of four handcrafted wooden coasters, made from reclaimed wood. Each coaster is unique.", "https://assets.bigcartel.com/product_images/233112323/coast+1+.jpg?auto=format&fit=max&w=1500", 19.99m, 40, 1, "Wooden Coasters" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2004), "Organic, homemade herbal soap infused with essential oils. Gentle on skin and eco-friendly.", "https://lovelygreens.com/wp-content/uploads/herbal-soap-calendula.jpg", 10.00m, 15, 1, "Herbal Soap" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1996), "A pair of hand-painted ceramic mugs with unique designs. Dishwasher and microwave safe.", "https://kariceramics.com/cdn/shop/products/Kari_ceramics_handmade_pottery_all_ceramic_mugs.jpg?v=1625917134", 35.00m, 25, 1, "Ceramic Mugs" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Image", "Seller" },
                values: new object[] { 1, "", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
