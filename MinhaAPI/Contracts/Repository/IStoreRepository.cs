using MinhaAPI.DTO;
using MinhaAPI.Entity;


namespace MinhaAPI.Contracts.Repository
{
    public interface IStoreRepository
    {
        Task<IEnumerable<StoreEntity>> Get();
    }
}
