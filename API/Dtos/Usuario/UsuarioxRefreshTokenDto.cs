
using API.Dtos.RefreshToken;

namespace API.Dtos.Usuario
{
    public class UsuarioxRefreshTokenDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public List<RefreshTokenDto> RefreshTokens { get; set; }
    }
}