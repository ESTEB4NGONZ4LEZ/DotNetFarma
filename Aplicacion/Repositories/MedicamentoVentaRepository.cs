
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class MedicamentoVentaRepository : GenericRepository<MedicamentoVenta>, IMedicamentoVenta
    {
        public MedicamentoVentaRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<MedicamentoVenta> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.MedicamentoVentas as IQueryable<MedicamentoVenta>;
            var totalRegistros = await query.CountAsync();
            var registros = await query.Skip((pageIndex - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();
            return (totalRegistros, registros);
        }

        async Task<MedicamentoVenta> IMedicamentoVenta.GetByIdVenta(int id)
        {
            return await _context.MedicamentoVentas
                                 .Where(x => x.IdVenta == id)
                                 .FirstAsync();
        }

        public async Task<dynamic> GetMedicamentosNoVendidos()
        {
            return await _context.Medicamentos
                                 .Where(medicamento =>
                                    !_context.MedicamentoVentas
                                 .Any(venta => venta.IdMedicamento == medicamento.Id))
                                 .ToListAsync();
        }
    }
}