using Estrutura.Data.Models;
using Estrutura.Data.Repositories.OperacaoRepository;
using Estrutura.Shared.NotificacaoWs;
using System;
using System.Threading.Tasks;

namespace Estrutura.Business.Services.OperacaoService
{
    public class OperacaoService : BaseService, IOperacaoService
    {
        private readonly IOperacaoRepository _operacaoRepository;

        public OperacaoService(INotificador notificador,
                               IOperacaoRepository operacaoRepository) : base(notificador)
        {
            _operacaoRepository = operacaoRepository;
        }

        public async Task<Guid> Cadastrar(Operacao operacao, string tela)
        {
            //TODO validações para cadastrar uma operação
            //loja e usuario recupera do cabeçalho da requisição
            //numero da operação obtem o ultimo + 1 considerando a loja
            //valida se o cliente foi informado, se não foi recupera o padrão

            return await _operacaoRepository.Cadastrar(operacao);

            //gravar log com o parametro da tela

        }

        public async Task Alterar(Operacao operacao, string tela, string descricaoLog)
        {
            //TODO validações para alterar uma operação

            //atualiza o usuario com o usuário logado

            await _operacaoRepository.SalvarAlteracoes(operacao);

            //gravar log com o parametro da tela e a descrição

        }

        public async Task Cancelar(Guid id, string tela)
        {
            var operacao = await _operacaoRepository.ObterParaAlterar(id);

            if (operacao == null)
            {
                NotificarAvisoRegistroNaoEncontrada("operação");
                return;
            }

            //Validar o motivo do cancelamento
            //Validar se existe caixa e se ele está aberto
            //Validar se a operação é uma entrada e se possui saldo em estoque (para os casos onde faz uma entrada, passa venda e cancela a entrada, o saldo pode ficar negativo)
            //Cancela os documentos fiscais

            operacao.Status = Shared.Enums.StatusOperacao.CANCELADA;

            await _operacaoRepository.SalvarAlteracoes(operacao);

            //gravar log com o parametro da tela
        }

        public async Task<Guid> Duplicar(Guid id, string tela)
        {
            var operacao = new Operacao();

            //Clona a operação
            //Se for uma venda, altera o tipo para pedido


            return await Cadastrar(operacao, tela);
        }
    }
}
