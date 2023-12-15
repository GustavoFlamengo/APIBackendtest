using Dapper;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;
using MinhaAPI.Infrastructure;

namespace MinhaAPI.Repository
{
    public class ProductRepository : Connection, IProductRepository
    {
        public async Task Add(ProductDTO user)
        {
           string sql = @"
                INSERT INTO product (Name, Description, OriginalPrice, CurrentPrice, Discount, Buyers)
                        VALUE (@Name, @Description, @OriginalPrice, @CurrentPrice, @Discount, @Buyers)
            ";

            await Execute(sql, user);
        }

        public async Task Delete(int id)
        {
            string sql = @"DELETE FROM product WHERE Id = @id";
            await Execute(sql, new {id });
        }

        public async Task<IEnumerable<ProductEntity>> Get()
        {
            string sql = "SELECT * FROM product";
            return await GetConnection().QueryAsync<ProductEntity>(sql);   
        }

        public async Task<ProductEntity> GetById(int id)
        {
            string sql = "SELECT * FROM product WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new {id});
        }

        public async Task Update(ProductEntity user)
        {
            string sql = @"
                UPDATE product 
                    SET Name = @Name,
                        Description = @Description,
                        OriginalPrice = @OriginalPrice,
                        CurrentPrice = @CurrentPrice,
                        Discount = @Discount,
                        Buyers = @Buyers
                WHERE Id = @Id
            ";
            await Execute(sql, user);
        }
    }
}
