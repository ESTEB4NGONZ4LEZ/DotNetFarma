
namespace Dominio.Entities
{
    public class Compra : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        public ICollection<MedicamentoCompra> MedicamentoCompras { get; set; }
    }
}