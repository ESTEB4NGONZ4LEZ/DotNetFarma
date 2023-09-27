
using API.Dtos.Empleado;

namespace API.Dtos.Ciudad
{
    public class CiudadxEmpleadoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }
        public List<EmpleadoDto> Empleados { get; set; }
    }
}