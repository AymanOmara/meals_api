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

        [HttpGet("GetMeals/{id}")]
        public ActionResult<IQueryable<MealDto>> GetMeals(int id)
        {
            var result = _repository.GetMeals(id);
            return Ok(_mapper.Map<List<MealDto>>(result));
        }
        //[HttpPost("AddMeal")]
        //public async Task<ActionResult<MealDto>> AddMeal([FromBody] CreateMealDto dto) {

        //}
    }
}

