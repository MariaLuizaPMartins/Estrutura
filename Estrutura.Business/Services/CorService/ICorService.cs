using Estrutura.Shared.ViewModels.Cor;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.CorService
{
    public interface ICorService
    {
        Task<Guid> Cadastrar(CorCadastroViewModel cadastroViewModel);
        Task Alterar(CorAlteracaoViewModel alteracaoViewModel);
        Task Excluir(Guid id);
        Task<CorViewModel> Obter(Guid id);
    }
}
