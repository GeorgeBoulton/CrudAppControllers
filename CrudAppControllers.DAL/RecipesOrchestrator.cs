using CrudAppControllers.DAL.Mappers;
using CrudAppControllers.DAL.Repositories;
using CrudAppControllers.Domain;
using CrudAppControllers.Domain.Models;

namespace CrudAppControllers.DAL;

// This is implementing a domain interface, so that it can be called from the domain but the domain doesnt know about the dal.
public class RecipesOrchestrator(IRecipesRepository recipesRepository, IRecipeMapper recipeMapper) : IRecipesOrchestrator
{
    public async Task<IEnumerable<Recipe>> RetrieveAndArrangeRecipes(string search)
    {
        var recipesDtoCollection = (await recipesRepository.GetBySearchAsync(search)).ToArray();
        var recipes = recipesDtoCollection.Select(recipeMapper.Map).ToArray();

        return recipes;
    }
}