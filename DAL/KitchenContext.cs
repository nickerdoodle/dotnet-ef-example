using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL;
public class KitchenContext : DbContext
{
    public DbSet<FoodItem> FoodItems { get; set; }

    public KitchenContext(DbContextOptions<KitchenContext> options) : base(options)
    {
    }
}
