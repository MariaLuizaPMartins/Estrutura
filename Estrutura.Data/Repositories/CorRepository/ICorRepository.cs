using Estrutura.Data.Models;
using System;
using System.Threading.Tasks;

namespace Estrutura.Data.Repositories.CorRepository
{
    public interface ICorRepository
    {
        Task<Guid> Cadastrar(Cor cor);
        Task Excluir(Guid id);


        Task<string> ObterDescricao(Guid id);
        bool ValidarDescricaoExistente(string descricao);
    }
}
