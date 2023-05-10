using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Models.LogisticaApi
{
    public class Ocorrencia
    {
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public Ocorrencia(DateTime? data, string descricao, string cidade, string uf)
        {
            Data = data;
            Descricao = descricao;
            Cidade = cidade;
            Uf = uf;
        }
    }
}
