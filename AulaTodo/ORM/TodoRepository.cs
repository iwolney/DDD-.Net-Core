using Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace ORM
{
    // Classe publica do Repositorio da classe Todo ITodoRepository
    public class TodoRepository : RepositoryConector, Interfaces.ITodoRepository
    {
        // Método construtor para poder herdar a classe RepositoryConector
        public TodoRepository(IConfiguration config) : base(config) { }

        public void Add(ToDo obj)
        {
            DynamicParameters par = new DynamicParameters();
            par.Add("@Tarefa", obj.Tarefa);

            string sql = "insert into todo (Tarefa) values (@Tarefa)";
            using (var cnn = new SqlConnection(base.GetConnection()))
            {
                cnn.Execute(sql, par);
                //cnn.Insert<ToDo>(obj);
            }
        }

        public ToDo Get(int id)
        {
            string sql = $"select * from Todo where Id = {id}";
            using (var cnn = new SqlConnection(base.GetConnection()))
            {
                return cnn.Query<ToDo>(sql).FirstOrDefault();
            }
        }
        public IEnumerable<ToDo> GetAll()
        {
            IEnumerable<ToDo> retorno;
            string sql = "select * from Todo";
            using (var cnn = new SqlConnection(base.GetConnection()))
            {
                retorno = cnn.Query<ToDo>(sql);
            }
            return retorno;
        }

        public void Remove(ToDo obj)
        {
            string sql = $"delete Todo where Id = {obj.Id}";
            using(var cnn = new SqlConnection(base.GetConnection()))
            {
                cnn.Execute(sql);
            }
        }

        public void Update(ToDo obj)
        {
            string sql = $"update Todo set Tarefa = @Tarefa where Id = {obj.Id}";
            DynamicParameters par = new DynamicParameters();
            par.Add("@Tarefa", obj.Tarefa);
            using (var cnn = new SqlConnection(base.GetConnection()))
            {
                cnn.Execute(sql, par);
            }
        }
    }
}
