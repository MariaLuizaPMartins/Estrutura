using Estrutura.Data.Models;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.Repository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task Insert(TEntity entity);
        Task Delete(params object[] keyValues);
    }
}
