﻿using Rovitex.Status.Rastreio.Domain.Models.LogisticaApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Interfaces
{
    public interface ILogisticaApiRepository
    {
        Task<StatusRastreio> DadosRastreio(string transportadora, string chaveNfe);
    }
}
