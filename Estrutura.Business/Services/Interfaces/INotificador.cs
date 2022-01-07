using Estrutura.Business.Helpers;
using System.Collections.Generic;

namespace Estrutura.Business.Services.Interfaces
{
    public interface INotificador
    {
        void Adicionar(Notificacao notificacao);
        List<Notificacao> ObterNotificacoesErro();
        List<Notificacao> ObterNotificacoesAviso();
        bool PossuiErros();
        bool PossuiAvisos();
    }
}
