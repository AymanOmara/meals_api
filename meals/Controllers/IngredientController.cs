using AutoMapper;
using meals.Data;
using meals.Dto;
using Microsoft.AspNetCore.Mvc;

namespace meals.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _repository;
        private readonly IMapper _mapper;
        public IngredientController(IIngredientRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("GetIngredients")]
        public ActionResult<IQueryable<Ingredient>> GetIngredients()
        {
            return Ok(_repository.GetIngredients());
        }
        [HttpPost("AddIngredient/{name}")]
        public ActionResult<IQueryable<Ingredient>> AddIngredients(string name)
        {
            return Ok(_repository.AddIngredient(name));
        }
        [HttpDelete("DeleteIngredient/{id}")]
        public ActionResult DeleteIngredient(int id)
        {
            _repository.DeleteIngredient(id);
            return Ok();
        }
        [HttpPut("UpdateIngredient")]
        public ActionResult UpdateIngreidnet([FromBody] IngredientUpdateOnly updateOnly)
        {
            var result = _repository.UpdateIngredient(_mapper.Map<Ingredient>(updateOnly));
            return Ok(result);
        }
    }
}

