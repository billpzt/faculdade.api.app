using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Faculdade._22E24.Domain.Entities;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Repository;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Services;

namespace Trabalho.Faculdade._22E24.Application.Services {
    public class LivroService : ILivroService {

        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository) {
            _livroRepository = livroRepository;
        }

        public void Adicionar(Livro livro) {
            _livroRepository.Adicionar(livro);
        }

        public void Atualizar(Livro livro) {
            _livroRepository.Atualizar(livro);
        }

        public void Remover(Livro livro) {
            _livroRepository.Remover(livro);
        }

        public IEnumerable<Livro> Listar(Livro livro) {
            return _livroRepository.Listar(livro);
        }

        public Livro Obter(Livro livro) {
            return _livroRepository.Obter(livro);
        }
    }
}
