
using API.Dtos.MedicamentoVenta;

namespace API.Dtos.Venta
{
    public class VentaxMedicamentoVentaDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public int IdPaciente { get; set; }
        public List<MedicamentoVentaDto> MedicamentoVentas { get; set; }
    }
}