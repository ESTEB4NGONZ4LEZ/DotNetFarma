
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class CargoRepository : GenericRepository<Cargo>, ICargo
    {
        public CargoRepository(MainContext context) : base(context)
        {
        }

        public override async Task<Cargo> GetByIdAsync(int id)
        {
            return await _context.Cargos
                                 .Include(x => x.Empleados)
                                 .FirstOrDefaultAsync(x => x.Id == id);    
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Cargo> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Cargos as IQueryable<Cargo>;
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