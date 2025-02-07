using api_basica.Interfaces.Utilities;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace api_basica.Utilities.Http
{
    public class HttpService : IHttpService
    {
        public readonly HttpClient _httpClient;

        public HttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        

        public async Task<IEnumerable<R>> Get<R>()
        {

            var response = await _httpClient.GetAsync(_httpClient.BaseAddress);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseStream = await response.Content.ReadAsStringAsync();

                var option = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                return JsonSerializer.Deserialize<IEnumerable<R>>(responseStream,option);
            }

            return Enumerable.Empty<R>();

        }
    }
}
