using Estrutura.Data.Models;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.OperacaoService
{
    public interface IOperacaoService
    {
        Task<Guid> Cadastrar(Operacao operacao, string tela);
        Task Alterar(Operacao operacao, string tela, string descricaoLog);
        Task Cancelar(Guid id, string tela);
    }
}
