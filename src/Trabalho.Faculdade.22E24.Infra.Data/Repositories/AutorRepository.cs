using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho.Faculdade._22E24.Domain.Entities;
using Trabalho.Faculdade._22E24.Domain.Interfaces.Repository;

namespace Trabalho.Faculdade._22E24.Infra.Data.Repositories {

    /// <summary>
    /// Implementação do repositorio
    /// </summary>
    public class AutorRepository : IAutorRepository {

        private const string ConnectionString = "";

        public void Adicionar(Autor autor) {
            string sql = $"insert into Autor (Id, Nome) values (@Id, @Nome);";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                connection.ExecuteScalar(sql, autor);
            }
        }

        public void Atualizar(Autor autor) {
            string sql = $"update from Autor set Nome = @Nome where Id = @Id;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                connection.ExecuteScalar(sql, autor);
            }
        }

        public void Remover(Autor autor) {
            string sql = $"delete from Livro where Id = @Id;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                connection.ExecuteScalar(sql, autor);
            }
        }

        public IEnumerable<Livro> Listar(Autor autor) {
            string sql = $"select * from Livro where Id = @Id or Nome = @Nome;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                return connection.Query<Autor>(sql, autor);
            }
        }

        public Autor Obter(Autor autor) {
            string sql = $"select * from Autor where Id = @Id;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                return connection.QueryFirstOrDefault<Autor>(sql, autor);
            }
        }
    }
}