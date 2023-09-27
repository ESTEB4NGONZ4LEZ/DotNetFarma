
using API.Dtos.Paciente;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PacienteController : BaseApiController
    {
        public PacienteController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        [HttpGet("all")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<PacienteDto>>> Get()
        {
            var registros = await _unitOfWork.Pacientes.GetAllAsync();
            if(registros == null) return NotFound();
            return _mapper.Map<List<PacienteDto>>(registros);   
        }

        [HttpGet("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PacienteDto>> GetById(int id)
        {
            var registro = await _unitOfWork.Pacientes.GetByIdAsync(id);
            if(registro == null) return NotFound(); 
            return _mapper.Map<PacienteDto>(registro);
        }

        [HttpPost]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PacienteDto>> Post(PacienteDto data)
        {
            var registro = _mapper.Map<Paciente>(data);
            if(registro == null) return BadRequest();
            _unitOfWork.Pacientes.Add(registro);
            await _unitOfWork.Save();
            return CreatedAtAction(nameof(Post), new { id = registro.Id }, registro);
        }

        [HttpPut("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PacienteDto>> Put(int id, [FromBody] PacienteDto dataUpdate)
        {
            if(dataUpdate == null) return NotFound();
            var registro = _mapper.Map<Paciente>(dataUpdate);
            registro.Id = id;
            _unitOfWork.Pacientes.Update(registro);
            await _unitOfWork.Save();
            return dataUpdate;
        }

        [HttpDelete("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
        {
            var registro = await _unitOfWork.Pacientes.GetByIdAsync(id);
            if(registro == null) return NotFound();
            _unitOfWork.Pacientes.Remove(registro);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpGet("pager")]
        // [Authorize]
        // [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<PacienteDto>>> GetAreaWhithPage([FromQuery] Params parameters)
        {
            var registros = await _unitOfWork.Pacientes.GetAllAsync
            (
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
            var lstAreas = _mapper.Map<List<PacienteDto>>(registros.registros);
            return new Pager<PacienteDto>
            (
                lstAreas,
                registros.totalRegistros,
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
        }

        [HttpGet("masDineroGastado")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<dynamic>> GetPacienteMasDineroGastado()
        {
            var registros = await _unitOfWork.Pacientes.GetPacienteMasDineroGastado();
            if(registros == null) return NotFound();
            return registros;  
        }
    }
}