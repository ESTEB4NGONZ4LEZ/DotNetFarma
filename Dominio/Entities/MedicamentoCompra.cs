
namespace Dominio.Entities
{
    public class MedicamentoCompra : BaseEntity
    {
        public int IdCompra { get; set; }
        public int IdMedicamento { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Compra Compra { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}