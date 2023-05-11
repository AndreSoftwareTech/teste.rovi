using Rovitex.Status.Rastreio.Domain.DTOs;
using Rovitex.Status.Rastreio.Domain.Entidades;
using Rovitex.Status.Rastreio.Domain.Models.LogisticaApi;

namespace Rovitex.Status.Rastreio.Domain.Interfaces
{
    public interface IStatusRastreioRepository
    {
        Task inserirocorrencia(StatusTransporteDto dto);
        
    }
}
