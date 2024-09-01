using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEnd.Migrations
{
    public partial class MigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateAdded", "Description", "Image", "Price", "QuantityAvailable", "SellerId", "Title" },
                values: new object[,]
                {
                    { 6, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "A beautifully handcrafted wooden bowl made from reclaimed oak wood. Perfect for serving salads or as a decorative piece.", "https://m.media-amazon.com/images/I/71A6SYOZwVL._AC_UF894,1000_QL80_.jpg", 35.99m, 12, 1, "Handcrafted Wooden Bowl" },
                    { 7, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handcrafted beaded dog collar made with durable leather and colorful, intricate beadwork. A unique accessory that adds style and comfort for your furry friend.", "https://swdistinctions.com/wp-content/uploads/2016/06/sw-mountain-collar-unnamed.png", 24.99m, 20, 1, "Handmade Beaded Dog Collar" },
                    { 8, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "A unique ceramic coffee mug, handcrafted and glazed in vibrant colors. Dishwasher and microwave safe.", "https://stellancworks.com/cdn/shop/products/20220406_125939_1024x1024@2x.jpg?v=1652184454", 18.50m, 30, 1, "Ceramic Coffee Mug" },
                    { 9, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Handmade leather-bound journal with recycled paper. Perfect for writing, sketching, or as a diary.", "https://www.galenleather.com/cdn/shop/products/refillable-leather-wrap-journal-planner-cover-crazy-horse-brown_2000x.jpg?v=1622296261", 45.00m, 15, 1, "Leather Journal" },
                    { 10, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "An elegant vase made from recycled glass, with a unique texture and shape. A great centerpiece for any room.", "https://i.ebayimg.com/images/g/FaUAAOSwcQdjka-Z/s-l400.jpg", 32.75m, 8, 1, "Recycled Glass Vase" },
                    { 11, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable and eco-friendly, this bamboo cutting board is handmade and treated with natural oils for a long-lasting finish.", "https://m.media-amazon.com/images/I/A16Lps3fycL._UF1000,1000_QL80_.jpg", 27.99m, 25, 1, "Bamboo Cutting Board" },
                    { 12, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A luxurious hand-painted silk scarf with floral motifs. Lightweight and perfect for all seasons.", "https://invisibleworld.com/cdn/shop/products/invisible-world-long-hand-painted-silk-scarf-monochrome-flowers-29200750608453_813x.jpg?v=1629674715", 65.00m, 10, 1, "Hand-Painted Silk Scarf" },
                    { 13, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hand-poured soy wax candle with a refreshing lavender scent. Burns cleanly and lasts up to 40 hours.", "https://i5.walmartimages.com/asr/85ea12b1-ecb7-431e-bb11-bfa665a31981.a444b21c5cc1654ad3b0f3fcb87b816f.jpeg?odnHeight=768&odnWidth=768&odnBg=FFFFFF", 15.50m, 40, 1, "Natural Soy Wax Candle" },
                    { 14, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A boho-inspired macramé wall hanging, hand-knotted with natural cotton rope. Adds a rustic touch to any home decor.", "https://m.media-amazon.com/images/I/91IQzXWHmQL.jpg", 55.00m, 7, 1, "Macramé Wall Hanging" },
                    { 15, new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Set of three hand-carved wooden spoons made from sustainably sourced walnut wood. Perfect for cooking and serving.", "https://images.squarespace-cdn.com/content/v1/5cb5bc4b7fdcb821197daa93/1676901378771-2J0XFNJ49RX8PL7XG1NB/Spoon+Set+with+Spoon+Rack2.jpeg?format=2500w", 30.00m, 16, 1, "Hand-Carved Wooden Spoon Set" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
