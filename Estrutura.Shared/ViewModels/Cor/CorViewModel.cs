using System;

namespace Estrutura.Shared.ViewModels.Cor
{
    public class CorViewModel
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public DateTime DataHoraUltimaAlteracao { get; set; }
    }
}
