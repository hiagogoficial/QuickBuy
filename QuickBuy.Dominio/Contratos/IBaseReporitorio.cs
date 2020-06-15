using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseReporitorio<TEntity> : IDisposable where TEntity : class
    {
        void Adcionar(TEntity entity);

        TEntity ObterPorID(int id);

        IEnumerable<TEntity> ObterTodos();

        void Atualizar(TEntity entity);

        void Remover(TEntity entity);
    }
}
