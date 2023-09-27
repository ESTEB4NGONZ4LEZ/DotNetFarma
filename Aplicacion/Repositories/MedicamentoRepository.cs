
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class MedicamentoRepository : GenericRepository<Medicamento>, IMedicamento
    {
        public MedicamentoRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Medicamento> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Medicamentos as IQueryable<Medicamento>;
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

        public async Task<List<Medicamento>> GetExpiran2024()
        {
            DateTime fechaInicial = new(2024, 01, 01);
            DateTime fechaLimite = new(2024, 12, 31);

            return await _context.Medicamentos 
                                 .Where(x => x.FechaExpiracion > fechaInicial && x.FechaExpiracion <= fechaLimite)
                                 .ToListAsync();
        }

        public async Task<dynamic> GetPacientesCompraronParacetamol()
        {
            int yearToFilter = 2023; // Año que deseas filtrar
            string medicamentoNombre = "paracetamol";

            return await _context.Pacientes
            .Where(paciente =>
                _context.Ventas
                    .Any(venta =>
                        venta.IdPaciente == paciente.Id &&
                        venta.Fecha.Year == yearToFilter &&
                        _context.MedicamentoVentas
                            .Any(medicamentoVenta =>
                                medicamentoVenta.IdVenta == venta.Id &&
                                _context.Medicamentos
                                    .Any(medicamento =>
                                        medicamentoVenta.IdMedicamento == medicamento.Id &&
                                        medicamento.Nombre.ToLower() == medicamentoNombre))))
            .ToListAsync();
        }

        public async Task<dynamic> GetMedicamentoMenosVendido()
        {
            int yearToFilter = 2023;

            return await _context.Medicamentos
                .GroupJoin(
                    _context.MedicamentoVentas
                        .Where(medicamentoVenta => medicamentoVenta.Venta.Fecha.Year == yearToFilter), // Filtra las ventas por el año 2023
                    medicamento => medicamento.Id,
                    medicamentoVenta => medicamentoVenta.IdMedicamento,
                    (medicamento, ventas) => new
                    {
                        Medicamento = medicamento,
                        CantidadVentas = ventas.Count()
                    })
                .OrderBy(resultado => resultado.CantidadVentas)
                .FirstOrDefaultAsync();
        }

        public async Task<dynamic> GetTotalMedicamentosVendidosxMes()
        {
            int yearToFilter = 2023;

            var medicamentosVendidosPorMesEn2023 = Enumerable.Range(1, 12)
                .Select(month => new
                {
                    Mes = month,
                    TotalMedicamentosVendidos = _context.Ventas
                        .Where(venta => venta.Fecha.Year == yearToFilter && venta.Fecha.Month == month)
                        .Join(
                            _context.MedicamentoVentas,
                            venta => venta.Id,
                            medicamentoVenta => medicamentoVenta.IdVenta,
                            (venta, medicamentoVenta) => medicamentoVenta.Cantidad)
                        .Sum()
                })
                .ToList();

            return medicamentosVendidosPorMesEn2023;
        }
    }
}