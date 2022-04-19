using Estrutura.Data.Models;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.CorService
{
    public interface ICorService
    {
        Task<Guid> Cadastrar(string descricao);
        Task Alterar(Guid id, string novaDescricao);
        Task Excluir(Guid id);
        Task<Cor> Obter(Guid id);
    }
}
