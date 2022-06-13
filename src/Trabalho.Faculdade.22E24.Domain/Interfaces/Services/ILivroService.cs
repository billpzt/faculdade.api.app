using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Faculdade._22E24.Domain.Entities;

namespace Trabalho.Faculdade._22E24.Domain.Interfaces.Services {
    public interface ILivroService {
        void Adicionar(Livro livro);
        void Atualizar(Livro livro);
        void Remover(Livro livro);
        Livro Obter(Livro livro);
        IEnumerable<Livro> Listar(Livro livro);
    }
}
