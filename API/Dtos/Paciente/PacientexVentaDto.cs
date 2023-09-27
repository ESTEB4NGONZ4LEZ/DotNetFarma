
using API.Dtos.Venta;

namespace API.Dtos.Paciente
{
    public class PacientexVentaDto
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public List<VentaDto> Ventas { get; set; }
    }
}