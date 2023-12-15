using Dapper;
using MinhaAPI.Entity;
using MinhaAPI.Infrastructure;
using MinhaAPI.Contracts;
using MinhaAPI.Contracts.Repository;

namespace MinhaAPI.Repository
{
    public class CategoryRepository : Connection, ICategoryRepository
    {
        public async Task<IEnumerable<CategoryEntity>> Get()
        {
            string sql = "SELECT * FROM category";
            return await GetConnection().QueryAsync<CategoryEntity>(sql);
        }
    }
}
