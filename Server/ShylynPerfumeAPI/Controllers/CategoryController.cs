using Microsoft.AspNetCore.Mvc;
using ShylynPerfumeAPI.Models;
using ShylynPerfumeAPI.Services.InterfaceServices;

namespace ShylynPerfumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            var result = await _categoryService.GetAllCategories();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Category>>> GetSingleCategory(Guid id)
        {
            var category = await _categoryService.GetSingleCategory(id);

            if (category is null)
            {
                return NotFound("Sorry, but this category dosen't exist.");
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<List<Category>>> CreateAsync(Category request)
        {
            var result = await _categoryService.CreateAsync(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Category>>> UpdateAsync(Guid id, Category request)
        {
            var result = await _categoryService.UpdateAsync(id, request);

            if (result is null)
                return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Category>>> DeleteAsync(Guid id)
        {
            var result = await _categoryService.DeleteAsync(id);
            if(result is null)
                return NotFound();
            return Ok(result);
        }
    }
}
