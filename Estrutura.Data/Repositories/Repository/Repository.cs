using Estrutura.Data.Context;
using Estrutura.Data.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        public readonly DbSet<TEntity> _DbSet;
        public readonly AppDbContext _AppDbContext;

        public Repository(AppDbContext appContext)
        {
            _DbSet = appContext.Set<TEntity>();
            _AppDbContext = appContext;
        }

        public virtual async Task Insert(TEntity entity)
        {
            _DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Delete(params object[] keyValues)
        {
            var entity = await _DbSet.FindAsync(keyValues);

            if (entity != null)
                _DbSet.Remove(entity);

            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await _AppDbContext.SaveChangesAsync();
        }
    }
}
