using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPiLavi.Models;

namespace TesteAPiLavi.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        public readonly string _connectionString;
        public PessoaRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Pessoa> GetAll()
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Pessoa>("SELECT Codigo, Nome, Endereco FROM Pessoa ORDER BY Nome ASC");
            }

        }
    }
}
