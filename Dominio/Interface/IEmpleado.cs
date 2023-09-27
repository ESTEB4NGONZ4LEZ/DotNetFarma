
using Dominio.Entities;

namespace Dominio.Interface
{
    public interface IEmpleado : IGeneric<Empleado>
    {
        Task<List<int>> GetIdEmpleados();
        Task<dynamic> GetVentasxEmpleado();
        Task<dynamic> GetEmpleados5Ventas();
        Task<dynamic> GetEmpleadosNoVentas();

    }
}