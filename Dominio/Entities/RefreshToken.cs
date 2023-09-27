
namespace Dominio.Entities
{
    public class RefreshToken : BaseEntity
    { 
        public string Token { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaExpiracion { get; set; }
        public bool EsRevocado { get; set; }
        public bool EstaActivo { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}