using MinhaAPI.DTO;
using MinhaAPI.Entity;

namespace MinhaAPI.Contracts.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryEntity>> Get();
    }
}
