using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Image? { get; set; }
    public bool Seller { get; set; }
}

