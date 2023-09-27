
namespace Dominio.Entities
{
    public class Ciudad : BaseEntity
    {
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}