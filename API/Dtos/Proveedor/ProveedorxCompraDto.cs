
using API.Dtos.Compra;

namespace API.Dtos.Proveedor
{
    public class ProveedorxCompraDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public List<CompraDto> Compras { get; set; }
    }
}