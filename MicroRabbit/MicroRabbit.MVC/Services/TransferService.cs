using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;

        public TransferService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task Transfer(TransferTDO trasferDTO)
        {
            var url = "http://localhost:5107/Banking";
            var content = new StringContent(
                JsonConvert.SerializeObject(trasferDTO),
                System.Text.Encoding.UTF8,
                "application/json");

            var responce = await _httpClient.PostAsync(url, content);
            responce.EnsureSuccessStatusCode();
        }
    }
}
