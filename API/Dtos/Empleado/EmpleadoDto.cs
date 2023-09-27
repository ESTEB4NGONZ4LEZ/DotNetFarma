
namespace API.Dtos.Empleado
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int IdCargo { get; set; }
        public int IdCiudad { get; set; }
        public int IdArl { get; set; }
        public int IdEps { get; set; }
    }
}