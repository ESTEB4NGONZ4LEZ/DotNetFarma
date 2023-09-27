
using API.Dtos.MedicamentoCompra;

namespace API.Dtos.Compra
{
    public class CompraxMedicamentoCompraDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdProveedor { get; set; }
        public List<MedicamentoCompraDto> MedicamentoCompras { get; set; }
    }
}