using System.Collections;
using System.Collections.Generic;
using Store.Domain.Entities;

namespace Store.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Select(int id);

        ICollection<T> SelectAll();
    }
}