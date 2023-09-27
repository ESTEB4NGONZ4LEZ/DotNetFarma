
using API.Dtos.MedicamentoVenta;

namespace API.Dtos.Medicamento
{
    public class MedicamentoxMedicamentoVentaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int IdProveedor { get; set; }
        public List<MedicamentoVentaDto> MedicamentoVentas { get; set; }
    }
}