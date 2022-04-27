using Estrutura.Data.Context;
using Estrutura.Data.Models;
using Estrutura.Data.Repositories.Repository;
using System;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.OperacaoRepository
{
    public class OperacaoRepository : Repository<Operacao>, IOperacaoRepository
    {
        public OperacaoRepository(AppDbContext context) : base(context) { }

        public async Task<Guid> Cadastrar(Operacao operacao)
        {
            await Insert(operacao);
            return operacao.Id;
        }

        public async Task<Operacao> ObterParaAlterar(Guid id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task SalvarAlteracoes(Operacao operacao)
        {
            operacao.DataHoraUltimaAlteracao = DateTime.UtcNow;
            await SaveChanges();
        }
    }
}
