namespace api_basica.Interfaces.Utilities
{
    public interface IHttpService
    {
        Task<IEnumerable<R>> Get<R>();
    }
}