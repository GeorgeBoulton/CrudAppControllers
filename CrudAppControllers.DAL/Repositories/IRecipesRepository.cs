using CrudAppControllers.DAL.Database.Entities;

namespace CrudAppControllers.DAL.Repositories;

public interface IRecipesRepository
{
    Task<IEnumerable<RecipeDto>> GetAllAsync(string search);
    Task<RecipeDto?> GetByIdAsync(int id);
    Task<IEnumerable<RecipeDto>> GetBySearchAsync(string search);
}