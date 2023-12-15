using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("Store")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _storeRepository;
        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _storeRepository.Get());
        }
    }
}
