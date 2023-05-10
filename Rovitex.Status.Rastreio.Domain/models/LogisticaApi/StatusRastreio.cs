using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Models.LogisticaApi
{
    public class StatusRastreio
    {
        public string ChaveNotaFiscal { get; set; }
        public bool Entregue { get; set; }
        public DateTime? DataEntrega { get; set; }
        public List<Ocorrencia> Ocorrencias { get; set; }

        public StatusRastreio()
        {
            Ocorrencias = new List<Ocorrencia>();
        }
    }
}
