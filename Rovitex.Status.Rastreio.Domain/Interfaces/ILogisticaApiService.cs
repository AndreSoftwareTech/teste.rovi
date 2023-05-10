using Rovitex.Status.Rastreio.Domain.DTOs;

namespace Rovitex.Status.Rastreio.Domain.Interfaces
{
    public interface ILogisticaApiService
    {
        Task<IEnumerable<OcorrenciaRastreioDTO>> ConsultarRastreio(string transportadora, string chaveNfe);
    }
}
