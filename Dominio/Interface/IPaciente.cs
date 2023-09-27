
using Dominio.Entities;

namespace Dominio.Interface
{
    public interface IPaciente : IGeneric<Paciente>
    {
        Task<dynamic> GetPacienteMasDineroGastado();
    }
}