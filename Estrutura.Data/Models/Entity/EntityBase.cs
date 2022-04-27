using Estrutura.Shared.NotificacaoWs;
using System;

namespace Estrutura.Data.Models.Entity
{
    public class EntityBase : FluentValidationType
    {
        public EntityBase()
        {
            DataHoraCadastro = DateTime.UtcNow;
            DataHoraUltimaAlteracao = DateTime.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public DateTime DataHoraUltimaAlteracao { get; set; }


        //public DateTime ObterDataHoraCadastro(int timezone)
        //{
        //    return DataHoraCadastro.AddHours(timezone);
        //}

        //public DateTime ObterDataHoraUltimaAlteracao(int timezone)
        //{
        //    return DataHoraUltimaAlteracao.AddHours(timezone);
        //}
    }
}
