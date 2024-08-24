using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;

public class Seller
{
	public int Id { get; set; } // Foreign Key to User
    [Required] 
    public string StoreName { get; set; }
    public string StoreDescription { get; set; }
}

