using Estrutura.Business.Services.CorServices;
using Estrutura.Shared.NotificacaoWs;
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
        public async Task<ActionResult> Cadastrar(string descricao)
        {
            try
            {
                return CustomResponse(await _corService.Cadastrar(descricao));
            }
            catch (Exception ex)
            {
                NotificarErro(ex);
            }

            return CustomResponse();
        }

        [HttpPut("alterar")]
        public async Task<ActionResult> Alterar(Guid id, string novaDescricao)
        {
            try
            {
                await _corService.Alterar(id, novaDescricao);
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
        public async Task<ActionResult> Obter(Guid id)
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
