
using API.Dtos.Ciudad;

namespace API.Dtos.Departamento
{
    public class DepartamentoxCiudadDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public List<CiudadDto> Ciudades { get; set; }
    }
}