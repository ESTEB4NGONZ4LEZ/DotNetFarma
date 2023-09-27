
using API.Dtos.Arl;
using API.Dtos.Cargo;
using API.Dtos.Ciudad;
using API.Dtos.Compra;
using API.Dtos.Departamento;
using API.Dtos.Empleado;
using API.Dtos.Eps;
using API.Dtos.Medicamento;
using API.Dtos.MedicamentoCompra;
using API.Dtos.MedicamentoVenta;
using API.Dtos.Paciente;
using API.Dtos.Pais;
using API.Dtos.Proveedor;
using API.Dtos.RefreshToken;
using API.Dtos.Rol;
using API.Dtos.Usuario;
using API.Dtos.Venta;
using AutoMapper;
using Dominio.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Arl, ArlDto>().ReverseMap();
            CreateMap<Arl, ArlxEmpleadoDto>().ReverseMap();

            CreateMap<Cargo, CargoDto>().ReverseMap();
            CreateMap<Cargo, CargoxEmpleadoDto>().ReverseMap();

            CreateMap<Ciudad, CiudadDto>().ReverseMap();
            CreateMap<Ciudad, CiudadxEmpleadoDto>().ReverseMap();

            CreateMap<Compra, CompraDto>().ReverseMap();
            CreateMap<Compra, CompraxMedicamentoCompraDto>().ReverseMap();

            CreateMap<Departamento, DepartamentoDto>().ReverseMap();
            CreateMap<Departamento, DepartamentoxCiudadDto>().ReverseMap();

            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoxVentaDto>().ReverseMap();

            CreateMap<Eps, EpsDto>().ReverseMap();
            CreateMap<Eps, EpsxEmpleadoDto>().ReverseMap();

            CreateMap<Medicamento, MedicamentoDto>().ReverseMap();
            CreateMap<Medicamento, MedicamentoxMedicamentoVentaDto>().ReverseMap();
            CreateMap<Medicamento, MedicamentoxMedicamentoCompraDto>().ReverseMap();

            CreateMap<MedicamentoCompra, MedicamentoCompraDto>().ReverseMap();

            CreateMap<MedicamentoVenta, MedicamentoVentaDto>().ReverseMap();

            CreateMap<Paciente, PacienteDto>().ReverseMap();
            CreateMap<Paciente, PacientexVentaDto>().ReverseMap();

            CreateMap<Pais, PaisDto>().ReverseMap();
            CreateMap<Pais, PaisxDepartamentoDto>().ReverseMap();

            CreateMap<Proveedor, ProveedorDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorxCompraDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorxMedicamentoDto>().ReverseMap();
            
            CreateMap<RefreshToken, RefreshTokenDto>().ReverseMap();

            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<Rol, RolxUsuarioDto>().ReverseMap();

            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, UsuarioxRefreshTokenDto>().ReverseMap();
            
            CreateMap<Venta, VentaDto>().ReverseMap();
            CreateMap<Venta, VentaxMedicamentoVentaDto>().ReverseMap();
        }
    }
}