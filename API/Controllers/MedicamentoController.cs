
using API.Dtos.Medicamento;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MedicamentoController : BaseApiController
    {
        public MedicamentoController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        [HttpGet("all")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<MedicamentoDto>>> Get()
        {
            var registros = await _unitOfWork.Medicamentos.GetAllAsync();
            if(registros == null) return NotFound();
            return _mapper.Map<List<MedicamentoDto>>(registros);   
        }

        [HttpGet("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MedicamentoDto>> GetById(int id)
        {
            var registro = await _unitOfWork.Medicamentos.GetByIdAsync(id);
            if(registro == null) return NotFound(); 
            return _mapper.Map<MedicamentoDto>(registro);
        }

        [HttpPost]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MedicamentoDto>> Post(MedicamentoDto data)
        {
            var registro = _mapper.Map<Medicamento>(data);
            if(registro == null) return BadRequest();
            _unitOfWork.Medicamentos.Add(registro);
            await _unitOfWork.Save();
            return CreatedAtAction(nameof(Post), new { id = registro.Id }, registro);
        }

        [HttpPut("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MedicamentoDto>> Put(int id, [FromBody] MedicamentoDto dataUpdate)
        {
            if(dataUpdate == null) return NotFound();
            var registro = _mapper.Map<Medicamento>(dataUpdate);
            registro.Id = id;
            _unitOfWork.Medicamentos.Update(registro);
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
            var registro = await _unitOfWork.Medicamentos.GetByIdAsync(id);
            if(registro == null) return NotFound();
            _unitOfWork.Medicamentos.Remove(registro);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpGet("pager")]
        // [Authorize]
        // [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<MedicamentoDto>>> GetAreaWhithPage([FromQuery] Params parameters)
        {
            var registros = await _unitOfWork.Medicamentos.GetAllAsync
            (
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
            var lstAreas = _mapper.Map<List<MedicamentoDto>>(registros.registros);
            return new Pager<MedicamentoDto>
            (
                lstAreas,
                registros.totalRegistros,
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
        }

        [HttpGet("expiran2024")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<MedicamentoDto>>> GetExpiracion2023()
        {
            var registros = await _unitOfWork.Medicamentos.GetExpiran2024();
            if(registros == null) return NotFound();
            return _mapper.Map<List<MedicamentoDto>>(registros);   
        }

        [HttpGet("compraronParacetamol")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<dynamic>> GetPacienteCompraronParacetamol()
        {
            var registros = await _unitOfWork.Medicamentos.GetPacientesCompraronParacetamol();
            if(registros == null) return NotFound();
            return registros; 
        }

        [HttpGet("menosVendido")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<dynamic>> GetMedicamentoMenosVendido()
        {
            var registros = await _unitOfWork.Medicamentos.GetMedicamentoMenosVendido();
            if(registros == null) return NotFound();
            return registros; 
        }

        [HttpGet("ventasxMes")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<dynamic>> GetTotalMedicamentosVendidosxMes()
        {
            var registros = await _unitOfWork.Medicamentos.GetTotalMedicamentosVendidosxMes();
            if(registros == null) return NotFound();
            return registros; 
        }
    }
}