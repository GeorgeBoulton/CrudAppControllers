using CrudAppControllers.Domain.Models;

namespace CrudAppControllers.Domain.Services;

public interface IRecipesService
{
    Task<IEnumerable<Recipe>> Process(string search);
}