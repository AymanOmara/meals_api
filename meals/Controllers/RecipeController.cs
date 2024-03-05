using AutoMapper;
using meals.Data;
using meals.Dto;
using Microsoft.AspNetCore.Mvc;

namespace meals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _repository;
        private readonly IMapper _mapper;
        public RecipeController(IRecipeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet("GetRecipes")]
        public ActionResult<IQueryable<ReadRecipeDto>> GetRecipes()
        {
            var result = _mapper.Map<List<ReadRecipeDto>>(_repository.GetRecipes());
            return Ok(result);
        }
        [HttpPost("AddRecipe")]
        public async Task<ActionResult<ReadRecipeDto>> AddRecipe([FromBody] AddRecipeDto dto)
        {
            var result = await _repository.AddRecipe(dto);
            return Ok(_mapper.Map<ReadRecipeDto>(result));
        }
        [HttpDelete("DeleteRecipe/{id}")]
        public ActionResult DeleteRecipe(int id) {
            _repository.DeleteRecipe(id);
            return Ok();
        }
    }
}

