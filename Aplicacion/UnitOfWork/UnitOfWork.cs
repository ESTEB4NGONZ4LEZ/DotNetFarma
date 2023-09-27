
using Aplicacion.Repositories;
using Dominio.Entities;
using Dominio.Interface;
using Persistencia;
using Persistencia.Data.Configuration;

namespace Aplicacion.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MainContext _context;
        public UnitOfWork(MainContext context)
        {
            _context = context;
        }
        private ArlRepository _arls;
        private CargoRepository _cargos;
        private CiudadRepository _ciudades;
        private CompraRepository _compras;
        private DepartamentoRepository _departamentos;
        private EmpleadoRepository _empleados;
        private EpsRepository _epses;
        private MedicamentoRepository _medicamentos;
        private MedicamentoCompraRepository _medicamentoCompras;
        private MedicamentoVentaRepository _medicamentoVentas;
        private PacienteRepository _pacientes;
        private PaisRepository _paises;
        private ProveedorRepository _proveedores;
        private RefreshTokenRepository _refreshToken;
        private RolRepository _roles;
        private UsuarioRepository _usuarios;
        private VentaRepository _ventas;
        public IArl Arls 
        {
            get
            {
                _arls ??= new ArlRepository(_context);
                return _arls;
            }
        }

        public ICargo Cargos 
        {
            get
            {
                _cargos ??= new CargoRepository(_context);
                return _cargos;
            }
        }

        public ICiudad Ciudades 
        {
            get
            {
                _ciudades ??= new CiudadRepository(_context);
                return _ciudades;
            }
        }

        public ICompra Compras 
        {
            get
            {
                _compras ??= new CompraRepository(_context);
                return _compras;
            }
        }

        public IDepartamento Departamentos 
        {
            get
            {
                _departamentos ??= new DepartamentoRepository(_context);
                return _departamentos;
            }
        }

        public IEmpleado Empleados 
        {
            get
            {
                _empleados ??= new EmpleadoRepository(_context);
                return _empleados;
            }
        }

        public IEps Epses 
        {
            get
            {
                _epses ??= new EpsRepository(_context);
                return _epses;
            }
        }

        public IMedicamento Medicamentos 
        {
            get
            {
                _medicamentos ??= new MedicamentoRepository(_context);
                return _medicamentos;
            }
        }
        public IMedicamentoVenta MedicamentoVentas 
        {
            get
            {
                _medicamentoVentas ??= new MedicamentoVentaRepository(_context);
                return _medicamentoVentas;
            }
        }

        public IPaciente Pacientes 
        {
            get
            {
                _pacientes ??= new PacienteRepository(_context);
                return _pacientes;
            }
        }

        public IPais Paises 
        {
            get
            {
                _paises ??= new PaisRepository(_context);
                return _paises;
            }
        }

        public IProveedor Proveedores 
        {
            get
            {
                _proveedores ??= new ProveedorRepository(_context);
                return _proveedores;
            }
        }

        public IRefreshToken RefreshTokens 
        {
            get
            {
                _refreshToken ??= new RefreshTokenRepository(_context);
                return _refreshToken;
            }
        }

        public IRol Roles 
        {
            get
            {
                _roles ??= new RolRepository(_context);
                return _roles;
            }
        }

        public IUsuario Usuarios 
        {
            get
            {
                _usuarios ??= new UsuarioRepository(_context);
                return _usuarios;
            }
        }

        public IVenta Ventas 
        {
            get
            {
                _ventas ??= new VentaRepository(_context);
                return _ventas;
            }
        }

        public IMedicamentoCompra MedicamentoCompras
        {
            get
            {
                _medicamentoCompras ??= new MedicamentoCompraRepository(_context);
                return _medicamentoCompras;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}