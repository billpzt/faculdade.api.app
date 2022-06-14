using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Faculdade._22E24.Domain.Entities;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Repository;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Services;

namespace Trabalho.Faculdade._22E24.Application.Services
{
    public class AutorService : IAutorService
    {

        private readonly IAutorRepository _autorRepository;

        public LivroService(IAutorRepository autorRepository) {
            _autorRepository = autorRepository;
        }

        public void Adicionar(Autor autor) {
            _autorRepository.Adicionar(autor);
        }

        public void Atualizar(Autor autor) {
            _autorRepository.Atualizar(autor);
        }

        public void Remover(Autor autor) {
            _autorRepository.Remover(autor);
        }

        public IEnumerable<Autor> Listar(Autor autor) {
            return _autorRepository.Listar(autor);
        }

        public Livro Obter(Autor autor) {
            return _autorRepository.Obter(autor);
        }
    }
}