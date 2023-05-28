using Microsoft.Extensions.DependencyInjection;
using MyProject.DataAccess.Modules.FoodItems;

namespace MyProject.DataAccess;

public static class KitchenExtension
{
    public static IServiceCollection AddKitchenModule(this IServiceCollection services)
    {
        services.AddScoped<IFoodItemsRepository, FoodItemsRepository>();
        return services;
    }
}
