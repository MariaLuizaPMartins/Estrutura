using Estrutura.Data.Context;
using Estrutura.Data.Models;
using Estrutura.Data.Repositories.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.CorRepository
{
    public class CorRepository : Repository<Cor>, ICorRepository
    {
        public CorRepository(AppDbContext context) : base(context) { }

        public bool ValidarDescricaoExistente(string descricao)
        {
            return _DbSet.Any(d => d.Descricao == descricao);
        }

        public async Task<Guid> Cadastrar(Cor cor)
        {
            await Insert(cor);
            return cor.Id;
        }

        public async Task Excluir(Guid id)
        {
            await Delete(id);
        }

        public async Task<string> ObterDescricao(Guid id)
        {
            return await _DbSet.Where(d => d.Id == id)
                               .Select(d => d.Descricao)
                               .FirstOrDefaultAsync();
        }
    }
}
