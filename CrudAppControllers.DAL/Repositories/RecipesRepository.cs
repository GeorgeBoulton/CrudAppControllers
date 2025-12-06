using CrudAppControllers.DAL.Database.Context;
using CrudAppControllers.DAL.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudAppControllers.DAL.Repositories;

public class RecipesRepository(RecipesContext context) : IRecipesRepository
{
    public async Task<IEnumerable<RecipeDto>> GetAllAsync(string search)
    {
        return await context.Recipes
            .ToArrayAsync();
    }
    
    public async Task<RecipeDto?> GetByIdAsync(int id)
    {
        return await context.Recipes
            .FirstOrDefaultAsync(x => x.Id == id);
    }
    
    public async Task<IEnumerable<RecipeDto>> GetBySearchAsync(string search)
    {
        return await context.Recipes
            .Where(x => x.Name.Contains(search))
            .ToListAsync();
    }
}