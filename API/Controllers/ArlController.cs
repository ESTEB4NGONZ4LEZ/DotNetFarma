
using API.Dtos.Arl;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ArlController : BaseApiController
    {
        public ArlController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        [HttpGet("all")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<ArlDto>>> Get()
        {
            var registros = await _unitOfWork.Arls.GetAllAsync();
            if(registros == null) return NotFound();
            return _mapper.Map<List<ArlDto>>(registros);   
        }

        [HttpGet("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ArlDto>> GetById(int id)
        {
            var registro = await _unitOfWork.Arls.GetByIdAsync(id);
            if(registro == null) return NotFound(); 
            return _mapper.Map<ArlDto>(registro);
        }

        [HttpPost]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ArlDto>> Post(ArlDto data)
        {
            var registro = _mapper.Map<Arl>(data);
            if(registro == null) return BadRequest();
            _unitOfWork.Arls.Add(registro);
            await _unitOfWork.Save();
            return CreatedAtAction(nameof(Post), new { id = registro.Id }, registro);
        }

        [HttpPut("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ArlDto>> Put(int id, [FromBody] ArlDto dataUpdate)
        {
            if(dataUpdate == null) return NotFound();
            var registro = _mapper.Map<Arl>(dataUpdate);
            registro.Id = id;
            _unitOfWork.Arls.Update(registro);
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
            var registro = await _unitOfWork.Arls.GetByIdAsync(id);
            if(registro == null) return NotFound();
            _unitOfWork.Arls.Remove(registro);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpGet("pager")]
        // [Authorize]
        // [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<ArlDto>>> GetAreaWhithPage([FromQuery] Params parameters)
        {
            var registros = await _unitOfWork.Arls.GetAllAsync
            (
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
            var lstAreas = _mapper.Map<List<ArlDto>>(registros.registros);
            return new Pager<ArlDto>
            (
                lstAreas,
                registros.totalRegistros,
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
        }
    }
}