using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.DTOs
{
    public class StatusTransporteDto
    {
        [Required]
        public int DescricaoId { get; set; }
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }
        [Required]
        [StringLength(100)]
        public DateTime DataEntrega { get; set; }
        [Required]
        [StringLength(100)]
        public int NumeroRegMovfat { get; set; }
    }
}