
using Dominio.Entities;

namespace Dominio.Interface
{
    public interface IVenta : IGeneric<Venta>
    {
        Task<List<int>> GetVentasMarzo();  
        Task<dynamic> GetPromedioMedicamentosVendidos();
    }
}