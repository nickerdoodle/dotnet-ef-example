using DAL.Models;

namespace DAL;

public static class DbSeeder
{
    public async static Task SeedData(KitchenContext kitchenContext)
    {
        if (!kitchenContext.FoodItems.Any())
        {
            var entities = new[]
            {
                new FoodItem { Id = 1, Name = "Chicken" },
                new FoodItem { Id = 2, Name = "Rice" },
                // Add more entities as needed
            };

            await kitchenContext.FoodItems.AddRangeAsync(entities);

            await kitchenContext.SaveChangesAsync();
        }
    }
}
