
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class PacienteRepository : GenericRepository<Paciente>, IPaciente
    {
        public PacienteRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Paciente> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Pacientes as IQueryable<Paciente>;
            if(!string.IsNullOrEmpty(search)) 
            {
                query = query.Where(x => x.Nombres.ToLower().Contains(search));
            }
            var totalRegistros = await query.CountAsync();
            var registros = await query.Skip((pageIndex - 1) * pageSize)
                                       .Take(pageSize)
                                       .ToListAsync();
            return (totalRegistros, registros);
        }

        public async Task<dynamic> GetPacienteMasDineroGastado()
        {
            int yearToFilter = 2023; 

            return await _context.Pacientes
                .Select(paciente => new
                {
                    Paciente = paciente,
                    GastoTotalEn2023 = _context.Ventas
                        .Where(venta => venta.Fecha.Year == yearToFilter && venta.IdPaciente == paciente.Id)
                        .Join(
                            _context.MedicamentoVentas,
                            venta => venta.Id,
                            medicamentoVenta => medicamentoVenta.IdVenta,
                            (venta, medicamentoVenta) => medicamentoVenta.Cantidad * medicamentoVenta.Precio)
                        .Sum()
                })
                .OrderByDescending(resultado => resultado.GastoTotalEn2023)
                .ToListAsync();
        }
    }
}