using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess.Models;

namespace MyProject.DataAccess;
public class KitchenContext : DbContext
{
    public DbSet<FoodItem> FoodItems { get; set; }

    public KitchenContext(DbContextOptions<KitchenContext> options) : base(options)
    {
    }
}
