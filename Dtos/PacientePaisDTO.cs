namespace api_basica.Dtos
{
    public class PacientePaisDTO
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FNacimiento { get; set; }
        public string NombrePais { get; set; } // Nombre del país en lugar de IdPais
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Observacion { get; set; }
    }
}
