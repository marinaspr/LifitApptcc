using LifitApp.Api;
using LifitApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LifitApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostagensController : ControllerBase
    {
        private static List<Postagem> _postagens = new List<Postagem>
        {
            new Postagem
            {
                Id = 1,
                Titulo = "Evento de Yoga",
                Descricao = "Sessão de yoga ao ar livre",
                Local = "Parque Central",
                Horario = "08:00",
                ImagemUrl = "https://exemplo.com/yoga.jpg"
            }
        };

        [HttpGet]
        public ActionResult<List<Postagem>> Get()
        {
            return Ok(_postagens);
        }
    }
}
