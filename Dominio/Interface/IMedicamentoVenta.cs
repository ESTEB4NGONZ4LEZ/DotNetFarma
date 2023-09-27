
using Dominio.Entities;

namespace Dominio.Interface
{
    public interface IMedicamentoVenta : IGeneric<MedicamentoVenta>
    {
        Task<MedicamentoVenta> GetByIdVenta(int id);
        Task<dynamic> GetMedicamentosNoVendidos();
    }
}