using Estrutura.Shared.NotificacaoWs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Estrutura.App.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly INotificador _notificador;

        public MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected ActionResult CustomResponse(object result = null)
        {
            try
            {
                if (_notificador.PossuiAvisos())
                {
                    return Ok(new
                    {
                        sucesso = false,
                        avisos = _notificador.ObterNotificacoesAviso().Select(n => n.Mensagem)
                    });
                }
                else if (_notificador.PossuiErros())
                {
                    return BadRequest(new
                    {
                        sucesso = false,
                        erros = _notificador.ObterNotificacoesErro().Select(n => n.Mensagem)
                    });
                }
                else
                {
                    return Ok(new
                    {
                        sucesso = true,
                        dados = result
                    });
                }

            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    sucesso = false,
                    erros = new List<string> { ex.ToString() }
                });
            }
        }

        protected void NotificarErro(Exception exception)
        {
            _notificador.Adicionar(new Notificacao(exception.ToString(), TipoNotificacao.ERRO));
        }
    }
}
