
namespace Dominio.Entities
{
    public class Paciente : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}