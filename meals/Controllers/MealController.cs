using AutoMapper;
using meals.Data.Meal;
using meals.Dto;
using Microsoft.AspNetCore.Mvc;

namespace meals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMealRepository _repository;
        private readonly IMapper _mapper;
        public MealController(IMealRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("GetMealz/{CategoryId}")]
        public ActionResult<IQueryable<ReadOnlyMealDto>> GetMealsByCategoryId(int CategoryId)
        {
            var result = _repository.GetMealsByCategoryId(CategoryId);
            return Ok(_mapper.Map<List<ReadOnlyMealDto>>(result));
        }
        [HttpPost("AddMeal")]
        public ActionResult<ReadOnlyMealDto> AddMeal([FromBody] WriteOnlyMealDto dto)
        {
            var result = _repository.AddMeal(dto);
            return Ok(_mapper.Map<ReadOnlyMealDto>(result));
        }
        [HttpPut("UpdateMeal/{id}")]
        public ActionResult<ReadOnlyMealDto> UpdateMeal(int id, [FromBody] WriteOnlyMealDto dto)
        {
            var result = _repository.UpdateMeal(id, dto);
            return Ok(_mapper.Map<ReadOnlyMealDto>(result));
        }
        [HttpDelete("DeleteMeal/{id}")]
        public ActionResult DeleteMeal(int id)
        {
            _repository.DeleteMeal(id);
            return Ok();
        }
    }
}

