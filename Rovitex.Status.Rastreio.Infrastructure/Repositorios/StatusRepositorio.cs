using Dapper;
using Rovitex.Status.Rastreio.Domain.Entidades;
using Rovitex.Status.Rastreio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Rovitex.Status.Rastreio.Infrastructure.Repositorios
{
    public class StatusRastreio : IStatusRastreio 
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatusRastreio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Teste()
        {
            var entidades = await _unitOfWork.Conexao.QueryAsync<TesteAndreEntidade>(@"SELECT NUMERO_NOTA AS NUMERONOTA, NUMERO_PEDIDO AS NUMEROPEDIDO, EMPRESARASTREIO, STATUS
                                                                                          FROM TESTEANDRE");

            foreach (var entidade in entidades)
            {
                Console.WriteLine($"Entidade: Numero Nota: {entidade.NumeroNota} - Numero Pedido: {entidade.NumeroPedido} - Empresa rastreio: {entidade.EmpresaRastreio} - Status: {entidade.Status}");
            }

            
        }
    }
}
