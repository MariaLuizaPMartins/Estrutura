using Estrutura.Data.Context;
using Estrutura.Data.Models;
using Estrutura.Data.Repositories.Interfaces;
using System.Linq;

namespace Estrutura.Data.Repositories
{
    public class CorRepository : RepositoryFind<Cor>, ICorRepository
    {
        public CorRepository(AppDbContext context) : base(context) { }

        public bool ValidarDescricaoExistente(string descricao)
        {
            return _DbSet.Any(d => d.Descricao == descricao);
        }
    }
}
