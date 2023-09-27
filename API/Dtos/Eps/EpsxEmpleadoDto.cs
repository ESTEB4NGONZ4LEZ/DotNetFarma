
using API.Dtos.Empleado;

namespace API.Dtos.Eps
{
    public class EpsxEmpleadoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public ICollection<EmpleadoDto> Empleados { get; set; }
    }
}