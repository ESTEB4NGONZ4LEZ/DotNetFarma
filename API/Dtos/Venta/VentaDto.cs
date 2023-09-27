
namespace API.Dtos.Venta
{
    public class VentaDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public int IdPaciente { get; set; }
    }
}