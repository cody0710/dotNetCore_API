using System.Collections.Generic;
using System.Threading.Tasks;
using netcore_api.Domain.Models;
using netcore_api.Domain.Services.Communication;

namespace netcore_api.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}