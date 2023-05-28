// This factory is needed in order to run our cli commands to add migrations to the database
// dotnet needs to know how to create the context at design time.
// This can be done a few ways, including in the Program.cs of the app
// But because we want the access layer separate from the project with the business logic,
// We need a solution outside of the startup, and since this is a class library, we can do it with a factory -- https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#from-a-design-time-factory

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyProject.DataAccess;

public class KitchenContextFactory : IDesignTimeDbContextFactory<KitchenContext>
{
    private IConfigurationRoot _configuration;

    public KitchenContextFactory()
    {
        _configuration = MyProject.DataAccess.ConfigurationProvider.GetConfiguration();
    }

    public KitchenContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<KitchenContext>();
        optionsBuilder.UseNpgsql(
            _configuration.GetConnectionString("DbName")
        );

        return new KitchenContext(optionsBuilder.Options);
    }
}
