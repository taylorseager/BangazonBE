using System.ComponentModel.DataAnnotations;
namespace BackEnd.Models;

public class User
{
    public string Id { get; set; }
    [Required]
    public string Image { get; set; }
    public bool Seller { get; set; }
}

