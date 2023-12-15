using MinhaAPI.DTO;
using MinhaAPI.Entity;

namespace MinhaAPI.Contracts.Repository
{
    public interface IProductRepository
    {
        Task Add(ProductDTO user);
        Task Update(ProductEntity product);      
        Task Delete(int id);
        Task<ProductEntity> GetById(int id);
        Task<IEnumerable<ProductEntity>> Get();
    }
}
