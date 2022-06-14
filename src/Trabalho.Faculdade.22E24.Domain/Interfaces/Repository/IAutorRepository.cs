using System;
using Trabalho.Faculdade._22E24.Domain.Entities;

namespace Trabalho.Faculdade._22E24.Domain.Interfaces.Repository {
	public interface IAutorRepository {
		void Adicionar(Autor autor);
        void Atualizar(Autor autor);
        void Remover(Autor autor);
        Livro Obter(Autor autor);
        IEnumerable<Livro> Listar(Autor autor);
    }
}
