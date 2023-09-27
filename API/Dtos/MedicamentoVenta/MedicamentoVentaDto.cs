
namespace API.Dtos.MedicamentoVenta
{
    public class MedicamentoVentaDto
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdMedicamento { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}