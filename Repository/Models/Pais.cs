using System.ComponentModel.DataAnnotations;

namespace api_basica.Repository.Models
{
    public class Pais
    {
        [Key]
        public string IdPais { get; set; }
        public  string PaisName { get; set; }
    }
}
