using Estrutura.Data.Models;
using System;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.OperacaoRepository
{
    public interface IOperacaoRepository
    {
        Task<Guid> Cadastrar(Operacao operacao);
        Task<Operacao> ObterParaAlterar(Guid id);
        Task SalvarAlteracoes(Operacao operacao);
    }
}
