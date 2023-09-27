
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class MedicamentoCompraRepository : GenericRepository<MedicamentoCompra>, IMedicamentoCompra
    {
        public MedicamentoCompraRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<MedicamentoCompra> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.MedicamentoCompras as IQueryable<MedicamentoCompra>;
            var totalRegistros = await query.CountAsync();
            var registros = await query.Skip((pageIndex - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();
            return (totalRegistros, registros);
        }
    }
}