using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;

public class Order
{
    public int Id { get; set; }
    [Required]
    public string UserId { get; set; } // Foreign Key to User
}

