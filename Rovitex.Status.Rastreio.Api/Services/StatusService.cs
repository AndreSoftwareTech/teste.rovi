using Rovitex.Status.Rastreio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Api.Services
{
    public class StatusRota : IStatusRota
    {
        private readonly IStatusRastreio teste;

        public StatusRota(IStatusRastreio statusRastreio)
        {
            teste = statusRastreio;
        }

        public void Processar()
        {
            teste.Teste().GetAwaiter().GetResult();
        }
    }
}
