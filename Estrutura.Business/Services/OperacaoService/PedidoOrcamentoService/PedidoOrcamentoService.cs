using Estrutura.Data.Models;
using Estrutura.Data.Repositories.OperacaoRepository;
using Estrutura.Shared.NotificacaoWs;
using Estrutura.Shared.ViewModels.Operacao.Pdv;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.OperacaoService.PedidoOrcamentoService
{
    public class PedidoOrcamentoService : BaseService, IPedidoOrcamentoService
    {
        private readonly IOperacaoService _operacaoService;
        private readonly IOperacaoRepository _operacaoRepository;

        public PedidoOrcamentoService(INotificador notificador,
                                      IOperacaoService operacaoService,
                                      IOperacaoRepository operacaoRepository) : base(notificador)
        {
            _operacaoService = operacaoService;
            _operacaoRepository = operacaoRepository;
        }

        public async Task<Guid> Cadastrar(PedidoOrcamentoCadastroViewModel cadastroViewModel)
        {
            var operacao = new Operacao
            {
                ClienteFornecedorId = cadastroViewModel.ClienteFornecedorId,
                VendedorId = cadastroViewModel.VendedorId,
                CaixaMovimentacaoId = cadastroViewModel.CaixaMovimentacaoId,
                TipoOperacao = cadastroViewModel.TipoOperacao
            };

            return await _operacaoService.Cadastrar(operacao, "pdv");

            //TODO notificar pedidos abertos
        }

        public async Task Alterar()
        {
            var operacao = await _operacaoRepository.ObterParaAlterar(new Guid());

            if (operacao == null)
            {
                NotificarAvisoRegistroNaoEncontrada("operação");
                return;
            }

            //altera os campos recebidos na viewmodel

            await _operacaoService.Alterar(operacao, "pdv", "descrição do que foi alterado");

            //TODO notificar pedidos abertos
        }

        public async Task Cancelar()
        {
            await _operacaoService.Cancelar(new Guid(), "pdv");

            //TODO notificar pedidos abertos
        }

        public async Task Duplicar()
        {

            //TODO notificar pedidos abertos
        }
    }
}
