using Estrutura.Shared.NotificacaoWs;

namespace Estrutura.Business.Services.OperacaoItemService.PedidoOrcamento.PedidoOrcamentoItemService
{
    public class PedidoOrcamentoItemService : BaseService, IPedidoOrcamentoItemService
    {
        public PedidoOrcamentoItemService(INotificador notificador) : base(notificador)
        {

        }

        public void Cadastrar()
        {
            //Verifica o saldo em estoque
            //Verifica se é um kit e adiciona os itens

            //Cadastra o item (OperacaoItemService.cadastrar)

            //Atualiza os totais da operação (OperacaoTotaisService.CalcularTotais)

            //grava log
        }

        public void Alterar()
        {
            //Valida se a operação não está cancelada
            //Valida se foi adicionado pagamento
            //Valida o saldo em estoque

            //Atualiza as informações do item
            //Atualiza as informações dos itens do kit

            //Altera o item (OperacaoItemService.alterar)

            //Atualiza os totais da operação (OperacaoTotaisService.CalcularTotais)

            //grava log
        }

        public void AtualizarItensKit()
        {
            //Obtem os itens do kit da operação
            //Verifica o cadastro para ver se os itens foram alterados/removidos

            //Altera os itens ou remove (OperacaoItemService.alterar) ou (OperacaoItemService.excluir)

            //Atualiza os totais da operação (OperacaoTotaisService.CalcularTotais)

            //grava log
        }

        public void Excluir()
        {
            //Valida se a operação não está cancelada
            //Valida se foi adicionado pagamento

            //Remove os itens e os itens do kit (OperacaoItemService.excluir)

            //Atualiza os totais da operação (OperacaoTotaisService.CalcularTotais)

            //grava log
        }
    }
}
