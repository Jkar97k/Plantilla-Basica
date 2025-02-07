using api_basica.Dtos;
using api_basica.Repository.Models;

namespace api_basica.Interfaces.Services
{
    public interface IPacienteSevices
    {
        Task Add(PacientePostDTO dto);
        Task Delete(int id);
        Task<IEnumerable<PacienteDTO>> ObtenerTodosLosPacientesAsync();
        Task Update(PacienteDTO dto);
    }
}