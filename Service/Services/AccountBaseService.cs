using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentValidation;
using Store.Data.Context;
using Store.Data.Repository;
using Store.Domain.Entities;
using Store.Domain.Entities.Account;
using Store.Domain.Interfaces;

namespace Store.Service.Services
{
    public class AccountBaseService<T> : IService<T> where T : BaseEntity
    {
        private readonly AccountBaseRepository<T> _repository = new AccountBaseRepository<T>();
        public static Person CreatePerson(User user)
        {
            var context = new AccountContext();
            Person person = null;
            person = context.Clients.FirstOrDefault(c => c.Email.Equals(user.Email.ToLower()));
            if (person == null)
                person = context.Employees.FirstOrDefault(e => e.Email.Equals(user.Email.ToLower()));

            return person;
        }

        public T Post<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<TV>());

            _repository.Insert(obj);

            return obj;
        }

        public T Put<TV>(T obj) where TV : AbstractValidator<T>
        {
            Validate(obj, Activator.CreateInstance<TV>());

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

        private static void Validate(T obj, IValidator<T> validator)
        {
            if (obj == null)
                throw new Exception("Object not Found!");

            validator.ValidateAndThrow(obj);
        }
    }
}
