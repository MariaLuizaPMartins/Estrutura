using System.Collections.Generic;
using System.Linq;

namespace Estrutura.Shared.NotificacaoWs
{
    public class NotificadorService : INotificador
    {
        private readonly List<Notificacao> _notificacoes;

        public NotificadorService()
        {
            _notificacoes = new List<Notificacao>();
        }

        public void Adicionar(Notificacao notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notificacao> ObterNotificacoesErro()
        {
            return _notificacoes.Where(x => x.TipoNotificacao == TipoNotificacao.ERRO).ToList();
        }

        public List<Notificacao> ObterNotificacoesAviso()
        {
            return _notificacoes.Where(x => x.TipoNotificacao == TipoNotificacao.AVISO).ToList();
        }

        public bool PossuiErros()
        {
            return _notificacoes.Any(x => x.TipoNotificacao == TipoNotificacao.ERRO);
        }

        public bool PossuiAvisos()
        {
            return _notificacoes.Any(x => x.TipoNotificacao == TipoNotificacao.AVISO);
        }
    }
}
