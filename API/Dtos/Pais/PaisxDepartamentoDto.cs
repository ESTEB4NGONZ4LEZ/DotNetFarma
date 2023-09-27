
using API.Dtos.Departamento;

namespace API.Dtos.Pais
{
    public class PaisxDepartamentoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<DepartamentoDto> Departamentos { get; set; }
    }
}