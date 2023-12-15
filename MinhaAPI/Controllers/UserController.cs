using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("Product")]
    public class UserController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public UserController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _productRepository.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductDTO user)
        {
            await _productRepository.Add(user);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductEntity user)
        {
            await _productRepository.Update(user);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _productRepository.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _productRepository.GetById(id));
        }

    }
}
