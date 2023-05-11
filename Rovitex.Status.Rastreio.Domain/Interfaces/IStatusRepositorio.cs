using Rovitex.Status.Rastreio.Domain.DTOs;
using Rovitex.Status.Rastreio.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Interfaces
{
    public interface IStatusRastreio
    {
        Task<IEnumerable<MovfatOcorrenciaFrete>> StatusConsulta(string transportadora, string chaveNfe);
    }
}
