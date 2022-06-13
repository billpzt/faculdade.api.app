using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trabalho.Faculdade._22E24.Domain.Entities;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Services;

namespace Trabalho.Faculdade._22E24.WebAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase {

        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService) {
            _livroService = livroService;
        }

        public string Adicionar() {
            Livro livro = new Livro {
                Id = 1,
                Nome = "O Segredo do Lobo"
            };

            _livroService.Adicionar(livro);

            string mensagem = "Registro salvo com sucesso.";
            return mensagem;
        }
    }
}
