using AutoMapper;
using meals.Data;
using meals.Dto;
using Microsoft.AspNetCore.Mvc;
namespace meals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet("Categories")]
        public ActionResult<IQueryable<Category>> GetCategories()
        {
            var result = _repository.GetCategories();
            return Ok(_mapper.Map<List<CategoryDTO>>(result));
        }
        [HttpPost("CreateCategory")]
        public async Task<ActionResult<CategoryDTO>> CreateCategory([FromBody] WriteOnlyCategoryDto category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            var result = await _repository.CreateCategory(categoryEntity);
            return Ok(_mapper.Map<CategoryDTO>(result));
        }
        [HttpPut("UpdateCategory/{id}")]
        public async Task<ActionResult<CategoryDTO>> UpdateCategory(int id, [FromBody] CategoryDTO category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            var result = await _repository.UpdateCategory(id, categoryEntity);
            return Ok(_mapper.Map<CategoryDTO>(result));
        }
        [HttpDelete("DeleteCategory/{id}")]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            await _repository.DeleteCategory(id);
            return Ok();
        }
        [HttpGet("GetRandomCategory")]
        public ActionResult<CategoryDTO> GetRandomCategory()
        {
            var result = _mapper.Map<CategoryDTO>(_repository.GetRandomCategory());

            return Ok(result);
        }
    }
}

