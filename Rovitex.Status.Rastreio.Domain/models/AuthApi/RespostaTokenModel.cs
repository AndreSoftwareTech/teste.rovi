using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rovitex.Status.Rastreio.Domain.Models.AuthApi
{
    public class RespostaTokenModel
    {
        public string AcessToken { get; set; }
        public int ExpiresIn { get; set; }
        public object UserData { get; set; }
        private DateTime _horaCriada { get; set; }
        public DateTime Validade { get => _horaCriada.AddSeconds(ExpiresIn); }

        public RespostaTokenModel()
        {
            _horaCriada = DateTime.Now;
        }
    }
}
