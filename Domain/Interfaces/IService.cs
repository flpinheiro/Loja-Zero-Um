using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Store.Domain.Entities;

namespace Store.Domain.Interfaces
{
    public interface IService<T> where  T : BaseEntity
    {
        /// <summary>
        /// O método POST é utilizado para submeter uma entidade a um recurso específico, frequentemente causando uma mudança no estado do recurso ou efeitos colaterais no servidor.
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        T Post<V>(T obj) where V : AbstractValidator<T>;

        /// <summary>
        /// O método PUT substitui todas as atuais representações do recurso de destino pela carga de dados da requisição.
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        T Put<V>(T obj) where V : AbstractValidator<T>;

        /// <summary>
        /// O método DELETE remove um recurso específico.
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// O método GET solicita a representação de um recurso específico. Requisições utilizando o método GET devem retornar apenas dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// O método GET solicita a representação de um recurso específico. Requisições utilizando o método GET devem retornar apenas dados.
        /// </summary>
        /// <returns></returns>
        ICollection<T> Get();
    }
}
