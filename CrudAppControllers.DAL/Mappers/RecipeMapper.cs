using CrudAppControllers.DAL.Database.Entities;
using CrudAppControllers.Domain.Models;

namespace CrudAppControllers.DAL.Mappers;

public class RecipeMapper : IRecipeMapper
{
    // If Dto was more complex object the mapping could change. here we are mapping into domain model for processing into domain.
    public Recipe Map(RecipeDto recipeDto) 
        => new(recipeDto.Id, recipeDto.Name, recipeDto.Description);
}