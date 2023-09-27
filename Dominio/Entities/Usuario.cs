
namespace Dominio.Entities
{
    public class Usuario : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public Rol Rol { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}