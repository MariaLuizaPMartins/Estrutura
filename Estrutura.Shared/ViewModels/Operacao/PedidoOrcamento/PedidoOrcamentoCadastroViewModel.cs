using Estrutura.Shared.Enums;
using System;

namespace Estrutura.Shared.ViewModels.Operacao.Pdv
{
    public class PedidoOrcamentoCadastroViewModel
    {
        public Guid VendedorId { get; set; }
        public Guid ClienteFornecedorId { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
        public Guid? CaixaMovimentacaoId { get; set; }
    }
}
