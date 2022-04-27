using Estrutura.Data.Models.Entity;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task Insert(TEntity entity);
        Task Delete(params object[] keyValues);
        Task<int> SaveChanges();
    }
}
