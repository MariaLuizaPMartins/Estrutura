using AutoMapper;
using Estrutura.Business.Validations;
using Estrutura.Data.Models;
using Estrutura.Data.Repositories.CorRepository;
using Estrutura.Shared.NotificacaoWs;
using Estrutura.Shared.Resources;
using Estrutura.Shared.ViewModels.Cor;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.CorService
{
    public class CorService : BaseService, ICorService
    {
        private readonly IMapper _mapper;
        private readonly ICorRepository _corRepository;

        public CorService(INotificador notificador,
                          ICorRepository corRepository,
                          IMapper mapper) : base(notificador)
        {
            _corRepository = corRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Cadastrar(CorCadastroViewModel cadastroViewModel)
        {
            var cor = _mapper.Map<Cor>(cadastroViewModel);

            if (VerificarSeDescricaoJaExiste(cor.Descricao))
            {
                return Guid.Empty;
            }

            if (!ExecutarValidacao(new CorValidation(), cor))
            {
                return Guid.Empty;
            }

            GravarLog("cadastrar", "cor", cor.Descricao);

            return await _corRepository.Cadastrar(cor);
        }

        public async Task Alterar(CorAlteracaoViewModel alteracaoViewModel)
        {
            var cor = await _corRepository.ObterParaAlterar(alteracaoViewModel.Id);

            if (!ValidarSeObjetoCorEstaPreenchido(cor))
            {
                return;
            }

            if (VerificarSeDescricaoJaExiste(cor.Descricao, cor.Id))
            {
                return;
            }

            cor.Descricao = alteracaoViewModel.Descricao;
            cor.Ativo = alteracaoViewModel.Ativo;

            if (!ExecutarValidacao(new CorValidation(), cor))
            {
                return;
            }

            await _corRepository.SalvarAlteracoes(cor);

            GravarLog("alterar", "cor", cor.Descricao);
        }

        public async Task Excluir(Guid id)
        {
            var descricao = await _corRepository.ObterDescricao(id);

            if (string.IsNullOrEmpty(descricao))
            {
                NotificarAviso(string.Format(ResourceMensagem.RegistroNaoEncontrada, "cor"));
                return;
            }

            await _corRepository.Excluir(id);

            GravarLog("excluir", "cor", descricao);
        }

        public async Task<CorViewModel> Obter(Guid id)
        {
            var cor = await _corRepository.ObterParaAlterar(id);

            if (!ValidarSeObjetoCorEstaPreenchido(cor))
            {
                return null;
            }

            var corViewModel = _mapper.Map<CorViewModel>(cor);
            corViewModel.DataHoraCadastro = cor.ObterDataHoraCadastro(-3);
            corViewModel.DataHoraUltimaAlteracao = cor.ObterDataHoraUltimaAlteracao(-3);

            return corViewModel;
        }

        private bool VerificarSeDescricaoJaExiste(string descricao, Guid? id = null)
        {
            if (_corRepository.VerificarSeDescricaoJaExiste(descricao, id))
            {
                NotificarAviso(string.Format(ResourceMensagem.JaExisteCadastroComMesmaDescricao, descricao));
                return true;
            }

            return false;
        }

        private bool ValidarSeObjetoCorEstaPreenchido(Cor cor)
        {
            if (cor == null)
            {
                NotificarAviso(string.Format(ResourceMensagem.RegistroNaoEncontrada, "cor"));
                return false;
            }

            return true;
        }

        private void GravarLog(string acao, string tela, string descricao)
        {
            //grava o log com a ação, tela, descrição, loja, usuário e data
        }
    }
}
