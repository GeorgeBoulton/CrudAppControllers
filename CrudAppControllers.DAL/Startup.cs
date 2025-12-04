using CrudAppControllers.DAL.Database.Context;
using Microsoft.Extensions.DependencyInjection;

namespace CrudAppControllers.DAL;

public static class Startup
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddDbContext<RecipesContext>();
    }
}