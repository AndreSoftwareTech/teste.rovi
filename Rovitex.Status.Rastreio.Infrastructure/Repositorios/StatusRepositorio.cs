using Rovitex.Status.Rastreio.Domain.Interfaces;
using Rovitex.Status.Rastreio.Domain.Entidades;
using Dapper;
using Rovitex.Status.Rastreio.Domain.Models.LogisticaApi;
using Rovitex.Status.Rastreio.Domain.DTOs;

namespace Rovitex.Status.Rastreio.Infrastructure.Repositorios
{
    public class StatusRepositorio: IStatusRastreioRepository
    {
        private readonly ILogisticaApiRepository _rastreio;
        private readonly IStatusRastreioRepository _status;

        private readonly IUnitOfWork _unitOfWork;

        public StatusRepositorio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }




        //public async Task inserirocorrencia(MovfatOcorrenciaFrete ocorrenciaFrete)
        //{
        //     await _unitOfWork.Conexao.ExecuteAsync(@"INSERT INTO Status_Transporte(DESCRICAO_ID, DESCRICAO, DATA_ENTREGA, NUMEREG_MOVFAT)
        //                                              Values(:DESCRICAO_ID, :DESCRICAO, :DATA_ENTREGA, :NUMEREG_MOVFAT )", ocorrenciaFrete);  
        //}

    public async Task InserirOcorrencia(StatusTransporteDto dto) { await _unitOfWork.Conexao.ExecuteAsync(@"INSERT INTO Status_Transporte(DESCRICAO_ID, DESCRICAO, DATA_ENTREGA, NUMEREG_MOVFAT)
                                                                        VALUES (:DescricaoId, :Descricao, :DataEntrega, :NumeroRegMovfat)", 
                                                                        new { DescricaoId = dto.DescricaoId, Descricao = dto.Descricao, DataEntrega = dto.DataEntrega, NumeroRegMovfat = dto.NumeroRegMovfat }); }


    }
}
