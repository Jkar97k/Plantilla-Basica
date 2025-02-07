namespace api_basica.Dtos
{
    public class PacientePostDTO
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? fNacimiento { get; set; }
        public string? IdPais { get; set; }
        public string Celular { get; set; }
        public string? Email { get; set; }
        public string? Observacion { get; set; }
    }
}
