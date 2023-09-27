
using API.Dtos.Empleado;

namespace API.Dtos.Cargo
{
    public class CargoxEmpleadoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<EmpleadoDto> Empleados { get; set; }
    }
}