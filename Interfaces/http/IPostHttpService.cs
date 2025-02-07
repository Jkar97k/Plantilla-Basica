using api_basica.Dtos;

namespace api_basica.Interfaces.http
{
    public interface IPostHttpService
    {
        Task<IEnumerable<PostJsonDTO>> Gethttp();
    }
}