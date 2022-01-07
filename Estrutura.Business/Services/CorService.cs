using Estrutura.Business.Services.Interfaces;
using Estrutura.Data.Models;
using Estrutura.Data.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services
{
    public class CorService : BaseService, ICorService
    {
        private readonly ICorRepository _find;
        private readonly IRepositoryActions<Cor> _actions;

        public CorService(INotificador notificador,
                          ICorRepository corRepository,
                          IRepositoryActions<Cor> actions) : base(notificador)
        {
            _find = corRepository;
            _actions = actions;
        }

        public async Task<Guid> Cadastrar(string descricao)
        {
            var cor = new Cor { Descricao = descricao };

            await _actions.Insert(cor);

            return cor.Id;
        }

        public async Task Alterar(Guid id, string novaDescricao)
        {
            var cor = await _find.FindByKey(id);

            if (cor == null)
            {
                NotificarAviso("A cor não foi encontrada.");
                return;
            }

            cor.Descricao = novaDescricao;
            await _actions.SaveChanges();
        }

        public async Task Excluir(Guid id)
        {
            var cor = await _find.FirstOrDefaultAsNoTracking(c => c.Id == id, c => new Cor { Id = c.Id });

            if (cor == null)
            {
                NotificarAviso("A cor não foi encontrada.");
                return;
            }

            await _actions.Delete(id);
        }

        public async Task<Cor> Obter(Guid id)
        {
            var cor = await _find.FindByKey(id);

            if (cor == null)
            {
                NotificarAviso("A cor não foi encontrada.");
                return null;
            }

            return cor;
        }
    }
}
