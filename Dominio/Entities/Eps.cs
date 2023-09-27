
namespace Dominio.Entities
{
    public class Eps : BaseEntity
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}