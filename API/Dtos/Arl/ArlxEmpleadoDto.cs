
using API.Dtos.Empleado;

namespace API.Dtos.Arl
{
    public class ArlxEmpleadoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public List<EmpleadoDto> Empleados { get; set; }
    }
}