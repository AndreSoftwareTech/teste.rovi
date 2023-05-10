using Rovitex.Status.Rastreio.Domain.Interfaces;
using Rovitex.Status.Rastreio.Domain.Models.LogisticaApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rovitex.Status.Rastreio.Domain.Interfaces;
using Rovitex.Status.Rastreio.Domain.Entidades;
using Dapper;

namespace Rovitex.Status.Rastreio.Infrastructure.Repositorios
{
    public class StatusRepositorio: IStatusService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatusRepositorio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Processar(MovfatOcorrenciaFrete ocorrenciaFrete)
        {
            
            
             await _unitOfWork.Conexao.ExecuteAsync(@"INSERT INTO Status_Transporte(DESCRICAO_ID, DESCRICAO, DATA_ENTREGA, NUMEREG_MOVFAT)
                                                      Values(:DESCRICAO_ID, :DESCRICAO, :DATA_ENTREGA, :NUMEREG_MOVFAT )", ocorrenciaFrete);
            
           
        }
      
     }
}
