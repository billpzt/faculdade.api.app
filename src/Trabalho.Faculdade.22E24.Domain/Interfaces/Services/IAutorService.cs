using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Faculdade._22E24.Domain.Entities;

namespace Trabalho.Faculdade._22E24.Domain.Interfaces.Services {
    public interface IAutorService {
        void Adicionar(Autor autor);
        void Atualizar(Autor autor);
        void Remover(Autor autor);
        Livro Obter(Autor autor);
        IEnumerable<Livro> Listar(Autor autor);
    }
}