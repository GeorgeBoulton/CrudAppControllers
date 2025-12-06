using CrudAppControllers.Domain.Services;
using CrudAppControllers.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace CrudAppControllers.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecipesController(IRecipesService recipesService, IRecipesMapper recipesMapper) : ControllerBase
{
    private IRecipesService _recipesService = recipesService;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRecipeById(int id)
    {
        var recipes = 
    }

    [HttpGet("search")]
    public async Task<IActionResult> GetRecipesBySearch([FromQuery] string search)
    {
        var recipes = (await recipesService.Process(search)).ToArray();
        var mappedRecipes = recipes.Select(recipesMapper.Map).ToArray();

        // todo extract to service, remember how to do the endpoint stuff.
        return mappedRecipes;
    }
}