
using Dominio.Entities;

namespace Dominio.Interface
{
    public interface IMedicamento : IGeneric<Medicamento>
    {
        Task<List<Medicamento>> GetExpiran2024();
        Task<dynamic> GetPacientesCompraronParacetamol();
        Task<dynamic> GetMedicamentoMenosVendido();
        Task<dynamic> GetTotalMedicamentosVendidosxMes();
    }
}