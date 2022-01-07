using Estrutura.Business.Helpers;
using Estrutura.Business.Helpers.Enums;
using Estrutura.Business.Services.Interfaces;

namespace Estrutura.Business.Services
{
    public class BaseService
    {
        private readonly INotificador _notificador;

        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void NotificarAviso(string mensagem)
        {
            _notificador.Adicionar(new Notificacao(mensagem, TipoNotificacao.AVISO));
        }

        protected void NotificarErro(string mensagem)
        {
            _notificador.Adicionar(new Notificacao(mensagem, TipoNotificacao.ERRO));
        }
    }
}
