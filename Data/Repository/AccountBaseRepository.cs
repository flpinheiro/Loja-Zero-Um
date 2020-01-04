using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Store.Data.Context;
using Store.Domain.Entities;
using Store.Domain.Interfaces;

namespace Store.Data.Repository
{
    public class AccountBaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AccountContext _context = new AccountContext();
        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        public T Select(int id) => _context.Set<T>().Find(id);

        public ICollection<T> SelectAll() => _context.Set<T>().ToList();
    }
}
