using api_basica.Dtos;
using api_basica.Interfaces.http;
using api_basica.Interfaces.Utilities;

namespace api_basica.Services.httpServices
{
    public class PostHttpService : IPostHttpService
    {
        public readonly IHttpService _httpService;

        public PostHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<IEnumerable<PostJsonDTO>> Gethttp()
        {

            var data = await _httpService.Get<PostJsonDTO>();

            return data.ToList();

        }
    }
}
