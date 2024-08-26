using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonDbContext>(builder.Configuration["BangazonDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// GET All Products
app.MapGet("api/products", (BangazonDbContext db) =>
{
    return db.Products.ToList();
});

// GET single product
app.MapGet("api/products/{id}", (BangazonDbContext db, int id) =>
{
    try
    {
        var selectedProduct = db.Products.Include(p => p.Id).Single(p => p.Id == id);

        return Results.Ok(selectedProduct);
    }

    catch (Exception)
    {
        return Results.NotFound();
    }
});

// GET single order
app.MapGet("api/orders/{id}", (BangazonDbContext db, int id) =>
{
    var selectedOrder = db.Orders.Include(o => o.Id).Single(o => o.Id == id);

    return Results.Ok(selectedOrder);
});

// Remove product from cart
app.MapDelete("/api/orderitem/{id}", (BangazonDbContext db, int id) =>
{
    OrderItem orderItem = db.OrderItems.FirstOrDefault(oi => oi.Id == id);
    if (orderItem == null)
    {
        return Results.NotFound();
    }
    db.OrderItems.Remove(orderItem);
    db.SaveChanges();
    return Results.NoContent();
});

// ADD product to cart
app.MapPost("/api/orderitem", (BangazonDbContext db, OrderItem orderItem) =>
{
    db.OrderItems.Add(orderItem);
    db.SaveChanges();
    return Results.Created($"/api/orderitem/{orderItem.Id}", orderItem);
});

// Check users
app.MapGet("/checkUserStatus/{uid}", (BangazonDbContext db, string uid) =>
{
    var user = db.Users.Where(u => u.Id == uid).ToList();
    if (uid == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(user);
});

app.MapGet("/api/user/{id}", (BangazonDbContext db, string id) =>
{
    User user = db.Users.FirstOrDefault(u => u.Id == id);
    if (id == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(user);
});

app.Run();
