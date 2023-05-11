using Newtonsoft.Json;
using Rovitex.Status.Rastreio.Domain.Interfaces;
using Rovitex.Status.Rastreio.Domain.Models.AuthApi;
using Rovitex.Status.Rastreio.Domain.Models.LogisticaApi;
using Rovitex.Status.Rastreio.Infrastructure.Repositorios;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;


namespace Rovitex.Status.Rastreio.Api.Services
{
    public class LogisticaApiRepository : ILogisticaApiRepository
    {
        private HttpClient _clienteApi;
        private readonly HttpClient _clienteAuth;
        private readonly AutenticacaoModel _autenticacaoModel;
        private RespostaTokenModel tokenModel;

        public LogisticaApiRepository(IHttpClientFactory httpClientFactory, AutenticacaoModel autenticacaoModel)
        {
            _clienteApi = httpClientFactory.CreateClient("LogisticaApi");
            _clienteAuth = httpClientFactory.CreateClient("AuthApi");
            _autenticacaoModel = autenticacaoModel;
        }

        private async Task Autenticacao()
        {
            try
            {
                if(tokenModel is not null && tokenModel.Validade < DateTime.Now)
                {
                    _clienteApi.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenModel.AcessToken);
                    return;
                }

                var content = new StringContent(JsonConvert.SerializeObject(_autenticacaoModel), Encoding.UTF8, "application/json");

                var response = await _clienteAuth.PostAsync("auth/signin", content);

                if (response.IsSuccessStatusCode)
                {
                    var conteudoResposta = await response.Content.ReadAsStringAsync();

                    tokenModel = JsonConvert.DeserializeObject<RespostaTokenModel>(conteudoResposta);

                    _clienteApi.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenModel.AcessToken);
                }
                else
                {

                }


            }catch(Exception ex)
            {

            }
        }


        public async Task<StatusRastreio> DadosRastreio(string transportadora, string chaveNfe)
        {
            await Autenticacao();

            var response = await _clienteApi.GetAsync($"transportadora/rastreio?chaveNotaFiscal={chaveNfe}&transportadora={transportadora}");

            if(response.IsSuccessStatusCode)
            {
                var conteudoResposta = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Domain.Models.LogisticaApi.ApiResponse>(conteudoResposta).Data;
            }

            throw new Exception();
        }
    }
}
