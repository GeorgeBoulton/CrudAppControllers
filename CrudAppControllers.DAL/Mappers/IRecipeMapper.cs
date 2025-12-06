using CrudAppControllers.DAL.Database.Entities;
using CrudAppControllers.Domain.Models;

namespace CrudAppControllers.DAL.Mappers;

public interface IRecipeMapper
{
    public Recipe Map(RecipeDto recipeDto);
}