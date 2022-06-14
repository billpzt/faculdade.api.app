using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trabalho.Faculdade._22E24.Domain.Entities;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Services;

namespace Trabalho.Faculdade._22E24.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase {

        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService) {
            _autorService = autorService;
        }

        public string Adicionar() {
            Autor autor = new Autor {
                Id = 1,
                Nome = "Trevannian"
            };

            _autorService.Adicionar(autor);

            string mensagem = "Registro salvo com sucesso.";
            return mensagem;
        }
    }
}