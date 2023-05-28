using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProject.DataAccess.Models;
using MyProject.DataAccess.Modules.FoodItems;

namespace MyProject.Controllers;

[ApiController]
[Route("[controller]")]
public class FoodItemsController : ControllerBase
{
    private readonly ILogger<FoodItemsController> _logger;
    private readonly IFoodItemsRepository _foodItemsRepository;

    public FoodItemsController(ILogger<FoodItemsController> logger, IFoodItemsRepository foodItemsRepository)
    {
        _logger = logger;
        _foodItemsRepository = foodItemsRepository;
    }

    [HttpGet()]
    public Task<IEnumerable<FoodItem>> GetAll()
    {
        // should not be returning model directly but mapping it
        var foodItems = _foodItemsRepository.GetAll();
        return foodItems;
    }

    [HttpGet("/{id}")]
    public Task<FoodItem> GetOne(int id)
    {
        var foodItem = _foodItemsRepository.GetOne(id);
        return foodItem;
    }
}
