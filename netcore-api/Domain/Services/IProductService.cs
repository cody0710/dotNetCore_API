using System.Threading.Tasks;
using netcore_api.Domain.Models;
using netcore_api.Domain.Models.Queries;
using netcore_api.Domain.Services.Communication;

namespace netcore_api.Domain.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}