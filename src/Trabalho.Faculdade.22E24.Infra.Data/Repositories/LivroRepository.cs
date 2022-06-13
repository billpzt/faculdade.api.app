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
    /// Implementação de do repositorio
    /// </summary>
    public class LivroRepository : ILivroRepository {

        private const string ConnectionString = "";

        public void Adicionar(Livro livro) {
            string sql = $"insert into Livro (Id, Nome) values (@Id, @Nome);";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                connection.ExecuteScalar(sql, livro);
            }
        }

        public void Atualizar(Livro livro) {
            string sql = $"update from Livro set Nome = @Nome where Id = @Id;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                connection.ExecuteScalar(sql, livro);
            }
        }

        public void Remover(Livro livro) {
            string sql = $"delete from Livro where Id = @Id;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                connection.ExecuteScalar(sql, livro);
            }
        }

        public IEnumerable<Livro> Listar(Livro livro) {
            string sql = $"select * from Livro where Id = @Id or Nome = @Nome;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                return connection.Query<Livro>(sql, livro);
            }
        }

        public Livro Obter(Livro livro) {
            string sql = $"select * from Livro where Id = @Id;";

            using (IDbConnection connection = new SqlConnection(ConnectionString)) {
                connection.Open();

                return connection.QueryFirstOrDefault<Livro>(sql, livro);
            }
        }
    }
}
