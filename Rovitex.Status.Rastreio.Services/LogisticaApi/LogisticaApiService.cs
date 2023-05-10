using Rovitex.Status.Rastreio.Domain.DTOs;
using Rovitex.Status.Rastreio.Domain.Interfaces;

namespace Rovitex.Status.Rastreio.Services.LogisticaApi
{
    public class LogisticaApiService : ILogisticaApiService
    {
        private readonly ILogisticaApiRepository _logisticaApiRepository;

        public LogisticaApiService(ILogisticaApiRepository logisticaApiRepository)
        {
            _logisticaApiRepository = logisticaApiRepository;
        }

        /// <summary>
        /// Busca os dados de rastreio na API de logistica e retorno um DTO do modelo do banco, caso a API não entregue os dados de rastreio
        /// retorna nulo.
        /// </summary>
        /// <param name="transportadora">CNPJ da transportadora</param>
        /// <param name="chaveNfe">Chave da nota fiscal do pedido a ser consultado</param>
        /// <returns>DTO dos modelo de rastreio ou nulo</returns>
        public async Task<IEnumerable<OcorrenciaRastreioDTO>> ConsultarRastreio(string transportadora, string chaveNfe)
        {
            var respostaApi = await _logisticaApiRepository.DadosRastreio(transportadora, chaveNfe);

            if (respostaApi is not null)
                return respostaApi.Ocorrencias.Select(ocorrencia => new OcorrenciaRastreioDTO()
                {
                    Descricao = ocorrencia.Descricao,
                    DataOcorrencia = ocorrencia.Data ?? default(DateTime)
                });

            return null;
        }
    }
}
