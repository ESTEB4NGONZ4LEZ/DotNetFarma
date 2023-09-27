
namespace Dominio.Entities
{
    public class Empleado : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaContratacion { get; set; }
        public int IdCargo { get; set; }
        public int IdCiudad { get; set; }
        public int IdArl { get; set; }
        public int IdEps { get; set; }
        public Cargo Cargo { get; set; }
        public Ciudad Ciudad { get; set; }
        public Arl Arl { get; set; }
        public Eps Eps { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}