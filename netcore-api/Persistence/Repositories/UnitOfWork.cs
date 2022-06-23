using System.Threading.Tasks;
using netcore_api.Domain.Repositories;
using netcore_api.Persistence.Contexts;

namespace netcore_api.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}