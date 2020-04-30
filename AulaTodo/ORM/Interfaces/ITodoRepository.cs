using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORM.Interfaces
{
    // Interface Repositório da classe Todo que herda do repositório genérico IRepository que recebe um tipo T == class (T é uma classe)
    public interface ITodoRepository : IRepository<ToDo>
    {
    }
}
