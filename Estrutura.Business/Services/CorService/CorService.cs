using Estrutura.Data.Models;
using Estrutura.Data.Repositories.CorRepository;
using Estrutura.Shared.NotificacaoWs;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.CorService
{
    public class CorService : BaseService, ICorService
    {
        private readonly ICorRepository _corRepository;

        public CorService(INotificador notificador,
                          ICorRepository corRepository) : base(notificador)
        {
            _corRepository = corRepository;
        }

        public async Task<Guid> Cadastrar(string descricao)
        {
            var cor = new Cor { Descricao = descricao };

            return await _corRepository.Cadastrar(cor);
        }

        public async Task Alterar(Guid id, string novaDescricao)
        {
            //var cor = await _corRepository.FindByKey(id);

            //if (cor == null)
            //{
            //    NotificarAviso("A cor não foi encontrada.");
            //    return;
            //}

            //cor.Descricao = novaDescricao;
            //await _actions.SaveChanges();
        }

        public async Task Excluir(Guid id)
        {
            var descricao = await _corRepository.ObterDescricao(id);

            if (string.IsNullOrEmpty(descricao))
            {
                NotificarAviso("A cor não foi encontrada.");
                return;
            }

            await _corRepository.Excluir(id);
        }

        public async Task<Cor> Obter(Guid id)
        {
            //var cor = await _corRepository.FindByKey(id);

            //if (cor == null)
            //{
            //    NotificarAviso("A cor não foi encontrada.");
            //    return null;
            //}

            //return cor;
            return null;
        }
    }
}
