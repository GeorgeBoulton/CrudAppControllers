using CrudAppControllers.Models;

namespace CrudAppControllers.Mappers;

public class RecipesMapper : IRecipesMapper
{
    public Recipe Map(Domain.Models.Recipe recipe)
    {
        return new Recipe(recipe.Id, recipe.Name);
    }
}