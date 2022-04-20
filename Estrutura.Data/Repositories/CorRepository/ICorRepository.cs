using Estrutura.Data.Models;
using System;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.CorRepository
{
    public interface ICorRepository
    {
        Task<Guid> Cadastrar(Cor cor);
        Task Excluir(Guid id);
        Task SalvarAlteracoes(Cor cor);


        Task<string> ObterDescricao(Guid id);
        Task<Cor> ObterParaAlterar(Guid id);


        bool VerificarSeDescricaoJaExiste(string descricao, Guid? id = null);
    }
}
