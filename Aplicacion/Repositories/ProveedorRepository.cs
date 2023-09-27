
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repositories
{
    public class ProveedorRepository : GenericRepository<Proveedor>, IProveedor
    {
        public ProveedorRepository(MainContext context) : base(context)
        {
        }

        public override async Task
        <(
            int totalRegistros,
            IEnumerable<Proveedor> registros
        )> GetAllAsync
        (
            int pageIndex,
            int pageSize,
            string search
        )
        {
            var query = _context.Proveedores as IQueryable<Proveedor>;
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

        public async Task<dynamic> GetTotalGananciaProveedor()
        {
            return await _context.Proveedores
                .Select(proveedor => new
                {
                    Proveedor = proveedor,
                    TotalCompra = _context.Compras
                        .Where(compra => compra.IdProveedor == proveedor.Id)
                        .Join(
                            _context.MedicamentoCompras,
                            compra => compra.Id,
                            medicamentoCompra => medicamentoCompra.IdCompra,
                            (compra, medicamentoCompra) => medicamentoCompra.Precio)
                        .Sum()
                })
                .ToListAsync();
        }

        public async Task<dynamic> GetProveedoresMasHanSuministrado()
        {
            int yearToFilter = 2023; // Año que deseas filtrar

            return await _context.Proveedores
                .Select(proveedor => new
                {
                    Proveedor = proveedor,
                    CantidadMedicamentosSuministrados = _context.Compras
                        .Where(compra => compra.Fecha.Year == yearToFilter && compra.IdProveedor == proveedor.Id)
                        .SelectMany(compra => compra.MedicamentoCompras)
                        .Sum(medicamentoCompra => medicamentoCompra.Cantidad)
                })
                .OrderByDescending(resultado => resultado.CantidadMedicamentosSuministrados)
                .FirstOrDefaultAsync();
        }
    }
}