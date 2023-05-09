using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IDbConnection Conexao { get; }
        void Commit();
        void BeginTransaction();
        void Rollback();
    }
}
