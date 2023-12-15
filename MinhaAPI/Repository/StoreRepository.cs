using Dapper;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;
using MinhaAPI.Infrastructure;

namespace MinhaAPI.Repository
{
    public class StoreRepository : Connection, IStoreRepository
    {
        public async Task<IEnumerable<StoreEntity>> Get()
        {
            string sql = "SELECT * FROM store";
            return await GetConnection().QueryAsync<StoreEntity>(sql);
        }
    }
}
