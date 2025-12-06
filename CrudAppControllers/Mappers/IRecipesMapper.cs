using CrudAppControllers.Models;

namespace CrudAppControllers.Mappers;

public interface IRecipesMapper
{
    Recipe Map(Domain.Models.Recipe recipe);
}