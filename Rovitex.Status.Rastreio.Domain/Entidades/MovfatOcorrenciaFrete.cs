using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Entidades
{
    public class MovfatOcorrenciaFrete
    {
        public decimal Descricao_Id { get; set; }
        public string Descricao { get; set; }
        public string Data_Entrega { get; set; }
        public string Numreg_Movfat { get; set; }
    }
}
