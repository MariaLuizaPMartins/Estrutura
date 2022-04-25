using Estrutura.Data.Models;
using Estrutura.Shared.Resources;
using FluentValidation;

namespace Estrutura.Business.Validations
{
    public class CorValidation : AbstractValidator<Cor>
    {
        public CorValidation()
        {
            RuleFor(f => f.Descricao)
                .NotNull().WithMessage(ResourceMensagem.CampoObrigatorio)
                .MaximumLength(50).WithMessage(ResourceMensagem.TamanhoMaximo);
        }
    }
}
