using QuickBuy.Dominio.Contratos;
using System.Collections.Generic;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseReporitorio<TEntity> where TEntity : class
    {
        public void Adcionar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity ObterPorID(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
