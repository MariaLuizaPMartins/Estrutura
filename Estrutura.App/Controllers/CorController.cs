using Estrutura.Business.Services.CorService;
using Estrutura.Shared.NotificacaoWs;
using Estrutura.Shared.ViewModels.Cor;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Estrutura.App.Controllers
{
    [ApiController]
    public class CorController : MainController
    {
        private readonly ICorService _corService;

        public CorController(INotificador notificador,
                             ICorService corService) : base(notificador)
        {
            _corService = corService;
        }

        [HttpPost("cadastrar")]
        public async Task<ActionResult> Cadastrar(CorCadastroViewModel cadastroViewModel)
        {
            try
            {
                return CustomResponse(await _corService.Cadastrar(cadastroViewModel));
            }
            catch (Exception ex)
            {
                NotificarErro(ex);
            }

            return CustomResponse();
        }

        [HttpPut("alterar")]
        public async Task<ActionResult> Alterar(CorAlteracaoViewModel alteracaoViewModel)
        {
            try
            {
                await _corService.Alterar(alteracaoViewModel);
            }
            catch (Exception ex)
            {
                NotificarErro(ex);
            }

            return CustomResponse();
        }

        [HttpDelete("excluir")]
        public async Task<ActionResult> Excluir(Guid id)
        {
            try
            {
                await _corService.Excluir(id);
            }
            catch (Exception ex)
            {
                NotificarErro(ex);
            }

            return CustomResponse();
        }

        [HttpGet("obter")]
        public async Task<ActionResult<CorViewModel>> Obter(Guid id)
        {
            try
            {
                return CustomResponse(await _corService.Obter(id));
            }
            catch (Exception ex)
            {
                NotificarErro(ex);
            }

            return CustomResponse();
        }
    }
}
