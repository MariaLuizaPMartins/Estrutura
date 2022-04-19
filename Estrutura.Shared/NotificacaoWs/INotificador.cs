using System.Collections.Generic;

namespace Estrutura.Shared.NotificacaoWs
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
