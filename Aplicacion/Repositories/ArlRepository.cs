
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class ArlRepository : GenericRepository<Arl>, IArl
    {
        public ArlRepository(MainContext context) : base(context)
        {
        }

        public override async Task<Arl> GetByIdAsync(int id)
        {
            return await _context.Arls
                                 .Include(x => x.Empleados)
                                 .FirstOrDefaultAsync(x => x.Id == id);    
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Arl> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Arls as IQueryable<Arl>;
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