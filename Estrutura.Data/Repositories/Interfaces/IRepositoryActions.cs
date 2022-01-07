using Estrutura.Data.Models;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.Interfaces
{
    public interface IRepositoryActions<TEntity> where TEntity : Entity
    {
        Task Insert(TEntity entity);
        Task Delete(params object[] keyValues);
        Task<int> SaveChanges();
    }
}
