using System;
using System.Collections.Generic;
using System.Text;

namespace ORM.Interfaces
{
    // Repositório Genérico para ser usado para todos os demais (recebe T => que é uma classa)
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T obj);
        void Remove(T obj);
        void Update(T obj);
    }
}
