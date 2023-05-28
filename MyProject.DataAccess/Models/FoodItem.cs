using System.ComponentModel.DataAnnotations;

namespace MyProject.DataAccess.Models;
public class FoodItem
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
}
