using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Contracts.Repository;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("categoria")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categorytRepository;
        public CategoryController(ICategoryRepository categoryRepository) 
        {
            _categorytRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _categorytRepository.Get());
        }

    }
}
