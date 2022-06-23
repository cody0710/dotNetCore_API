using System.Threading.Tasks;

namespace netcore_api.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}