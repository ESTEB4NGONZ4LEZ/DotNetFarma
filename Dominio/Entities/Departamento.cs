
namespace Dominio.Entities
{
    public class Departamento : BaseEntity
    {
        public string Nombre { get; set; }
        public int IdPais { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Ciudad> Ciudades { get; set; }
    }
}