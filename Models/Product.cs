using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public int SellerId { get; set; } // Foreign Key to Seller
    [Required]
    public string Title? { get; set; }
    public string Description? { get; set; }
    public int QuantityAvailable? { get; set; }
    public decimal Price? { get; set; }
    public string Image? { get; set; }
    public DateTime DateAdded { get; set; }
}

