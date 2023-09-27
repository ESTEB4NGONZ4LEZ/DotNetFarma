
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleado
    {
        public EmpleadoRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Empleado> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Empleados as IQueryable<Empleado>;
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

        public async Task<List<int>> GetIdEmpleados()
        {
            return await _context.Empleados
                                 .Select(x => x.Id)
                                 .ToListAsync();
        }

        public async Task<dynamic> GetVentasxEmpleado()
        {
            return await _context.Empleados
                                 .GroupJoin
                                 (
                                    _context.Ventas
                                            .Where(x => x.Fecha.Year == 2023),
                                            Empleado => Empleado.Id,
                                            Venta => Venta.IdEmpleado,
                                            (Empleado, Venta) => new
                                            {
                                                Id = Empleado.Id,
                                                Nombre = Empleado.Nombres,
                                                TotalVentas = Venta.Count()
                                            }
                                 ).ToListAsync();
        }

        public async Task<dynamic> GetEmpleados5Ventas()
        {
            int minVentas = 5;

            return await _context.Empleados
                                .GroupJoin(
                                    _context.Ventas,
                                    empleado => empleado.Id,
                                    venta => venta.IdEmpleado,
                                    (empleado, ventas) => new
                                    {
                                        Id = empleado.Id,
                                        Empleado = empleado.Nombres,
                                        CantidadVentas = ventas.Count()
                                    })
                                .Where(resultado => resultado.CantidadVentas > minVentas) // Filtra empleados con más de 5 ventas
                                .ToListAsync();
        }

        public async Task<dynamic> GetEmpleadosNoVentas()
        {
            int yearToFilter = 2023;

            return await _context.Empleados
                .Where(empleado =>
                    !_context.Ventas.Any(venta =>
                        venta.IdEmpleado == empleado.Id && venta.Fecha.Year == yearToFilter))
                .ToListAsync();
        }
    }
}