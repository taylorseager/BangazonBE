using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;

public class Order
{
    public int Id { get; set; }
    [Required]
    public int UserId { get; set; } // Foreign Key to User
}

