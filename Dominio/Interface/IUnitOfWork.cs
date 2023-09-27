
namespace Dominio.Interface
{
    public interface IUnitOfWork
    {
        IArl Arls { get; }
        ICargo Cargos { get; }
        ICiudad Ciudades { get; }
        ICompra Compras { get; }
        IDepartamento Departamentos { get; }
        IEmpleado Empleados { get; }
        IEps Epses { get; }
        IMedicamento Medicamentos { get; }
        IMedicamentoCompra MedicamentoCompras { get; }
        IMedicamentoVenta MedicamentoVentas { get; }
        IPaciente Pacientes { get; }
        IPais Paises { get; }
        IProveedor Proveedores { get; }
        IRefreshToken RefreshTokens { get; }
        IRol Roles { get; }
        IUsuario Usuarios { get; }
        IVenta Ventas { get; }
        Task<int> Save();
    }
}