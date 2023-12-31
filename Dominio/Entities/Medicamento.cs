
namespace Dominio.Entities
{
    public class Medicamento : BaseEntity
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public ICollection<MedicamentoCompra> MedicamentoCompras { get; set; }
        public ICollection<MedicamentoVenta> MedicamentoVentas { get; set; }
    }
}