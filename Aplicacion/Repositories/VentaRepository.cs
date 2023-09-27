
using System.Security.Cryptography.X509Certificates;
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class VentaRepository : GenericRepository<Venta>, IVenta
    {
        public VentaRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Venta> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Ventas as IQueryable<Venta>;
            var totalRegistros = await query.CountAsync();
            var registros = await query.Skip((pageIndex - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();
            return (totalRegistros, registros);
        }
        public async Task<List<int>> GetVentasMarzo()
        {
            DateTime fechaInicio = new(2023, 03, 01);
            DateTime fechaLimite = new(2023, 03, 31);

            return await _context.Ventas
                                 .Where(x => x.Fecha >= fechaInicio && x.Fecha <= fechaLimite)
                                 .Select(x => x.Id)
                                 .ToListAsync();
        }
        
        public async Task<dynamic> GetPromedioMedicamentosVendidos()
        {
            return await _context.Ventas
                .Select(venta => new
                {
                    Venta = venta,
                    CantidadMedicamentos = _context.MedicamentoVentas
                        .Where(medicamentoVenta => medicamentoVenta.IdVenta == venta.Id)
                        .Sum(medicamentoVenta => medicamentoVenta.Cantidad)
                })
                .AverageAsync(resultado => resultado.CantidadMedicamentos);
        }
    }
}