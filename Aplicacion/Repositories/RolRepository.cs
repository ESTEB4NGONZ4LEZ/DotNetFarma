
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        public RolRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Rol> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Roles as IQueryable<Rol>;
            if(!string.IsNullOrEmpty(search)) 
            {
                query = query.Where(x => x.Nombre.ToLower().Contains(search));
            }
            var totalRegistros = await query.CountAsync();
            var registros = await query.Skip((pageIndex - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();
            return (totalRegistros, registros);
        }
    }
}