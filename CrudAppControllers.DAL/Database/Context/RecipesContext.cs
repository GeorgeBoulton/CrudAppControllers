using CrudAppControllers.DAL.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CrudAppControllers.Config.AppSettings;

namespace CrudAppControllers.DAL.Database.Context;

public class RecipesContext : DbContext
{
    public RecipesContext(DbContextOptions<RecipesContext> options) : base(options)
    {
    }
    
    public virtual DbSet<RecipeDto> Recipes { get; set; }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RecipesContext>
{
    public RecipesContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder().Build();
        var builder = new DbContextOptionsBuilder<RecipesContext>();
        var connectionString = configuration.GetConnectionString(ConnectionStrings.RecipesDatabase);
        builder.UseNpgsql(connectionString);

        return new RecipesContext(builder.Options);
    }
}