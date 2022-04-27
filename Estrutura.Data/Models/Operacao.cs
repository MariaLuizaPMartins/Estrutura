using Estrutura.Data.Models.Entity;
using Estrutura.Shared.Enums;
using System;

namespace Estrutura.Data.Models
{
    public class Operacao : EntityBase
    {
        public Guid UsuarioId { get; set; }
        public Guid LojaId { get; set; }
        public Guid ClienteFornecedorId { get; set; }
        public Guid? TransportadoraId { get; set; }
        public Guid? CaixaMovimentacaoId { get; set; }
        public Guid? VendedorId { get; set; }
        public Guid? TabelaPrecoId { get; set; }
        public Guid LocalEstoqueId { get; set; }
        public Guid? FaturaId { get; set; }

        public long NumeroOperacao { get; set; } // Sequencial por Loja
        public StatusOperacao Status { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
        public DateTime DataCompetencia { get; set; }
        public string CnpjCpf { get; set; }
        public string Observacao { get; set; }
        public string Historico { get; set; }
        public string MotivoCancelamento { get; set; }
        public string NumeroDocumento { get; set; }

        public decimal ValorTotal { get; set; }
        public decimal ValorTotalDescontoItem { get; set; }
        public decimal ValorTotalDescontoAdicional { get; set; }
        public decimal ValorDescontoAdicional { get; set; }
        public TipoValor TipoDescontoAdicional { get; set; }
        public decimal ValorTotalAcrescimo { get; set; }
        public decimal ValorTotalOutrasDespesas { get; set; }
        public decimal ValorTotalFrete { get; set; }
        public decimal ValorTotalItensSemDesconto { get; set; }
        public decimal ValorTotalItensComDesconto { get; set; }
    }
}
