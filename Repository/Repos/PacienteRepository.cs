using api_basica.Interfaces.Repository;
using api_basica.Repository.Base;
using api_basica.Repository.Context;
using api_basica.Repository.Models;

namespace api_basica.Repository.Repos
{
    public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
    {
        public PacienteRepository(CentroMedicoContext context) : base(context)
        {
        }


    }
}
