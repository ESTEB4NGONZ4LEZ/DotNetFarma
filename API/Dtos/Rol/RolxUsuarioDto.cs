
using API.Dtos.Usuario;

namespace API.Dtos.Rol
{
    public class RolxUsuarioDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<UsuarioDto> Usuarios { get; set; }
    }
}