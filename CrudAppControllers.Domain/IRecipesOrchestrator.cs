using CrudAppControllers.Domain.Models;

namespace CrudAppControllers.Domain;

public interface IRecipesOrchestrator
{
    Task<IEnumerable<Recipe>> RetrieveAndArrangeRecipes(string search);
}