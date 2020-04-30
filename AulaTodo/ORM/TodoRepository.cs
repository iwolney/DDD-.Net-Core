using Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace ORM
{
    // Classe publica do Repositorio da classe Todo ITodoRepository
    public class TodoRepository : RepositoryConector, Interfaces.ITodoRepository
    {
        // Método construtor para poder herdar a classe RepositoryConector
        public TodoRepository(IConfiguration config) : base(config) { }

        public void Add(ToDo obj)
        {
            using(var cnn = new SqlConnection(base.GetConnection()))
            {
                //cnn.Insert<ToDo>(obj);
            }
        }

        public ToDo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> GetAll()
        {
            IEnumerable<ToDo> retorno;
            string sql = "select * from Todo";
            using(var cnn = new SqlConnection(base.GetConnection()))
            {
                retorno = cnn.Query<ToDo>(sql);
            }
            return retorno;
        }

        public void Remove(ToDo obj)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDo obj)
        {
            throw new NotImplementedException();
        }
    }
}
