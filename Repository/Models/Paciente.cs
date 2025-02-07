using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_basica.Repository.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int IdPaciente { get; set; }
        public  string Nombre { get; set; }
        public  string Apellido { get; set; }
        public DateTime FNacimiento  { get; set; }
        public string IdPais { get; set; }
        public  string Celular { get; set; }
        public  string Email { get; set; }
        public  string? Observacion { get; set; }

        [ForeignKey("IdPais")]
        public virtual Pais? Pais { get; set; }


    }
}
