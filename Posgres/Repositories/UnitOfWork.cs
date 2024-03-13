using Posgres.Data;
using Posgres.Entities;
using Posgres.Interfaces;

namespace Posgres.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TaskDbContext _context;
        public UnitOfWork(TaskDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Role> Roles => new GenericRepository<Role>(_context);

        public IGenericRepository<User> Users => new GenericRepository<User>(_context);

        public IGenericRepository<TaskItem> Tasks => new GenericRepository<TaskItem>(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
