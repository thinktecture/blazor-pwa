using BlazorConfListPWA.DTO;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorConfListPWA.Services
{
    public class ConferencesService
    {
        private HttpClient _httpClient;
        private string _conferencesUrl = "https://api-ttconftool.azurewebsites.net/api/v1/conferences";

        public ConferencesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ConferencesResponse> GetConferences()
        {
            var result = await _httpClient.GetJsonAsync<ConferencesResponse>(_conferencesUrl);

            return result;
        }
    }
}
