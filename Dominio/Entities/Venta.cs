
namespace Dominio.Entities
{
    public class Venta : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public int IdEmpleado { get; set; }
        public int IdPaciente { get; set; }
        public Empleado Empleado { get; set; }
        public Paciente Paciente { get; set; }
        public ICollection<MedicamentoVenta> MedicamentoVentas { get; set; }
    }
}