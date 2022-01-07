using Estrutura.Data.Models;

namespace Estrutura.Data.Repositories.Interfaces
{
    public interface ICorRepository : IRepositoryFind<Cor>
    {
        bool ValidarDescricaoExistente(string descricao);
    }
}
