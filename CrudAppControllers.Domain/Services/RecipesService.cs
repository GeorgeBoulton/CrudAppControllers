using CrudAppControllers.Domain.Models;

namespace CrudAppControllers.Domain.Services;

public class RecipesService(IRecipesOrchestrator recipesOrchestrator) : IRecipesService
{
    public async Task<IEnumerable<Recipe>> Process(string search)
    {
        var recipes = (await recipesOrchestrator.RetrieveAndArrangeRecipes(search)).ToArray();
        
        //todo do some processing here
        return recipes;
    }
}