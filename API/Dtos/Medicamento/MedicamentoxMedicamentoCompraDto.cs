
using API.Dtos.MedicamentoCompra;

namespace API.Dtos.Medicamento
{
    public class MedicamentoxMedicamentoCompraDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int IdProveedor { get; set; }
        public List<MedicamentoCompraDto> MedicamentoCompras { get; set; }
    }
}