using Estrutura.Shared.NotificacaoWs;
using System;

namespace Estrutura.Data.Models
{
    public class Entity : FluentValidationType
    {
        public Entity()
        {
            DataHoraCadastro = DateTime.UtcNow;
            DataHoraUltimaAlteracao = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public DateTime DataHoraUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }

        public DateTime ObterDataHoraCadastro(int timezone)
        {
            return DataHoraCadastro.AddHours(timezone);
        }

        public DateTime ObterDataHoraUltimaAlteracao(int timezone)
        {
            return DataHoraUltimaAlteracao.AddHours(timezone);
        }
    }
}
