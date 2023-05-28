using MyProject.DataAccess.Models;

namespace MyProject.DataAccess.Modules.FoodItems;

public interface IFoodItemsRepository
{
    public Task<IEnumerable<FoodItem>> GetAll();
    public Task AddOne(FoodItem foodItem);
    public Task<FoodItem> GetOne(int id);
}
