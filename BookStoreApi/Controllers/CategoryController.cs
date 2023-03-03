using BLL.Dtos;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
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

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody] CategoryDto category)
        {
            try
            {
                if (!ModelState.IsValid)
                    throw new Exception("");
                var Category = await _categoryService.AddAsync(category);

                var result = new APiResponse<CategoryDto>()
                {
                    Code = 200,
                    Status = "Passed",
                    Result = Category,
                    Message = "Category Added Succuefully",
                    Errors = null,
                };
                return Ok(result);

                

            } catch (Exception ex)
            {
                var error = ex.Message;
                var result = new APiResponse<object>()
                {
                    Code = 400,
                    Status = "Failed",
                    Errors = error.ToString(),
                    Message = "Internal Error",
                    Result = null

                };

                return Ok(result);

            }
        }

    }
}
