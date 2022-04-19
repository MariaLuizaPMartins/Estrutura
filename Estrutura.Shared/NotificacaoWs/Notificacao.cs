namespace Estrutura.Shared.NotificacaoWs
{
    public class Notificacao
    {
        public Notificacao(string mensagem, TipoNotificacao tipoNotificacao)
        {
            Mensagem = mensagem;
            TipoNotificacao = tipoNotificacao;
        }

        public string Mensagem { get; }
        public TipoNotificacao TipoNotificacao { get; }
    }
}
