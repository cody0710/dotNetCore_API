using System.Collections.Generic;
using System.Threading.Tasks;
using netcore_api.Domain.Models;
using netcore_api.Domain.Models.Queries;

namespace netcore_api.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task AddAsync(Product product);
        Task<Product> FindByIdAsync(int id);
        void Update(Product product);
        void Remove(Product product);
    }
}