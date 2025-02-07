using api_basica.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace api_basica.Repository.Context
{
    public class CentroMedicoContext : DbContext
    {
        public CentroMedicoContext(DbContextOptions<CentroMedicoContext> options) : base(options) 
        {
        }

        public virtual DbSet<Paciente> Paciente { get; set; }

        public virtual DbSet<Pais> Pais { get; set; }
    }
}
