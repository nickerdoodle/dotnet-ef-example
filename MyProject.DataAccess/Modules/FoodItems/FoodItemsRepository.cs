using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess.Models;

namespace MyProject.DataAccess.Modules.FoodItems;

public class FoodItemsRepository : IFoodItemsRepository
{
    private KitchenContext _kitchenContext;

    public FoodItemsRepository(KitchenContext kitchenContext)
    {
        _kitchenContext = kitchenContext;
    }

    public async Task AddOne(FoodItem foodItem)
    {
        await _kitchenContext.FoodItems.AddAsync(foodItem).ConfigureAwait(false);
        await _kitchenContext.SaveChangesAsync().ConfigureAwait(false);
    }

    public async Task<IEnumerable<FoodItem>> GetAll()
    {
        return await _kitchenContext.FoodItems.ToListAsync();
    }

    public async Task<FoodItem> GetOne(int id)
    {
        var foodItem = await _kitchenContext.FoodItems.SingleAsync(record => record.Id == id).ConfigureAwait(false);

        return foodItem;
    }
}
