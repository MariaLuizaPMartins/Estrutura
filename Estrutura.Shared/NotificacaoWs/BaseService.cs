using Estrutura.Shared.Resources;
using FluentValidation;
using FluentValidation.Results;

namespace Estrutura.Shared.NotificacaoWs
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

        protected void NotificarAvisoRegistroNaoEncontrado(string nome)
        {
            NotificarAviso(string.Format(ResourceMensagem.RegistroNaoEncontrado, nome));
        }

        protected void NotificarAvisoRegistroNaoEncontrada(string nome)
        {
            NotificarAviso(string.Format(ResourceMensagem.RegistroNaoEncontrada, nome));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : FluentValidationType
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }

        private void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                NotificarAviso(error.ErrorMessage);
            }
        }
    }
}
