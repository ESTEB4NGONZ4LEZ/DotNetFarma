
namespace API.Dtos.MedicamentoCompra
{
    public class MedicamentoCompraDto
    {
        public int Id { get; set; }
        public int IdCompra { get; set; }
        public int IdMedicamento { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}