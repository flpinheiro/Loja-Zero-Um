using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Store.Data.Repository;
using Store.Domain.Entities;
using Store.Domain.Interfaces;

namespace Store.Service.Services
{
    public class AccountBaseService<T> : IService<T> where T : BaseEntity
    {

        private readonly AccountBaseRepository<T> _repository = new AccountBaseRepository<T>();
        public T Post<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            _repository.Insert(obj);

            return obj;
        }

        public T Put<V>(T obj) where V : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<V>());

            _repository.Update(obj);

            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can`t be zero.");

            _repository.Remove(id);
        }

        public T Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("The id can`t be zero.");

            return _repository.Select(id);
        }

        public ICollection<T> Get() => _repository.SelectAll();

        private void Validate(T obj, IValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Object not Found!");

            validator.ValidateAndThrow(obj);
        }
    }
}
