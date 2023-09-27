
using Dominio.Entities;

namespace Dominio.Interface
{
    public interface IProveedor : IGeneric<Proveedor>
    {
        Task<dynamic> GetTotalGananciaProveedor();
        Task<dynamic> GetProveedoresMasHanSuministrado();
    }
}