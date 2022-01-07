using Estrutura.Data.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.Interfaces
{
    public interface IRepositoryFind<TEntity> where TEntity : Entity
    {
        Task<TEntity> FindByKey(params object[] keyValues);
        Task<TEntity> FirstOrDefaultAsNoTracking(Expression<Func<TEntity, bool>> predicate = null, Expression<Func<TEntity, TEntity>> select = null);
    }
}
