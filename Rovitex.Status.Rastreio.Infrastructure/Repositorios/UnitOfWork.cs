using Rovitex.Status.Rastreio.Domain.Interfaces;

using System.Data;

namespace Rovitex.Status.Rastreio.Infrastructure.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbConnection _connection;
        private IDbTransaction _transaction;

        public UnitOfWork(IDbConnection connection)
        {
            _connection = connection;
            if (_connection.State != ConnectionState.Open)
                _connection.Open();
        }

        public IDbConnection Conexao => _connection;


        public void BeginTransaction()
        {
            if (_transaction is null)
            {
                _transaction = _connection.BeginTransaction();
            }
        }



        public void Commit()
        {
            if (_transaction is not null)
            {
                _transaction.Commit();
            }
        }



        public void Rollback()
        {
            if (_transaction is not null)
            {
                _transaction.Rollback();
            }
        }


    }
}
