
namespace Dominio.Entities
{
    public class MedicamentoVenta : BaseEntity
    {
        public int IdVenta { get; set; }
        public int IdMedicamento { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Venta Venta { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}