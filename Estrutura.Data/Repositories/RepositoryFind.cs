using Estrutura.Data.Context;
using Estrutura.Data.Models;
using Estrutura.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories
{
    public class RepositoryFind<TEntity> : IRepositoryFind<TEntity> where TEntity : Entity
    {
        public readonly DbSet<TEntity> _DbSet;
        public readonly AppDbContext _AppDbContext;

        public RepositoryFind(AppDbContext appContext)
        {
            _DbSet = appContext.Set<TEntity>();
            _AppDbContext = appContext;
        }

        public async Task<TEntity> FindByKey(params object[] keyValues)
        {
            return await _DbSet.FindAsync(keyValues);
        }

        public async Task<TEntity> FirstOrDefaultAsNoTracking(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, TEntity>> select = null)
        {
            if (predicate != null)
            {
                if (select == null)
                {
                    return _DbSet.AsNoTracking().Where(predicate).FirstOrDefault();
                }
                else
                {
                    return _DbSet.AsNoTracking().Where(predicate).Select(select).FirstOrDefault();
                }
            }

            if (select != null)
            {
                return _DbSet.AsNoTracking().Select(select).FirstOrDefault();
            }

            return await _DbSet.AsNoTracking().FirstOrDefaultAsync();
        }
    }
}
