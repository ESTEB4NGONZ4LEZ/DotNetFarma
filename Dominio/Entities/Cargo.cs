
namespace Dominio.Entities
{
    public class Cargo : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}