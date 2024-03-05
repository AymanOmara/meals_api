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
        public ActionResult<IQueryable<GetIngredientDto>> GetIngredients()
        {
            var result = _repository.GetIngredients();
            return Ok(_mapper.Map<List<GetIngredientDto>>(result));
        }
        [HttpPost("AddIngredient/{name}")]
        public ActionResult<IQueryable<GetIngredientDto>> AddIngredients(string name)
        {
            var result = _repository.AddIngredient(name);
            return Ok(_mapper.Map<GetIngredientDto>(result));
        }
        [HttpDelete("DeleteIngredient/{id}")]
        public ActionResult DeleteIngredient(int id)
        {
            _repository.DeleteIngredient(id);
            return Ok();
        }
        [HttpPut("UpdateIngredient")]
        public ActionResult<GetIngredientDto> UpdateIngreidnet([FromBody] GetIngredientDto updateOnly)
        {
            var result = _repository.UpdateIngredient(_mapper.Map<Ingredient>(updateOnly));

            return Ok(_mapper.Map<GetIngredientDto>(result));
        }
    }
}

