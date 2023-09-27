
using API.Dtos.Pais;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class PaisController : BaseApiController
{
    public PaisController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    [HttpGet("all")]
    // [Authorize(Roles = "Administrador, Gerente")]
    // [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<List<PaisDto>>> Get()
    {
        var registros = await _unitOfWork.Paises.GetAllAsync();
        if(registros == null) return NotFound();
        return _mapper.Map<List<PaisDto>>(registros);   
    }

    [HttpGet("{id}")]
    // [Authorize(Roles = "Administrador, Gerente")]
    // [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<PaisDto>> GetById(int id)
    {
        var registro = await _unitOfWork.Paises.GetByIdAsync(id);
        if(registro == null) return NotFound(); 
        return _mapper.Map<PaisDto>(registro);
    }

    [HttpPost]
    // [Authorize(Roles = "Administrador, Gerente")]
    // [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<PaisDto>> Post(PaisDto data)
    {
        var registro = _mapper.Map<Pais>(data);
        if(registro == null) return BadRequest();
        _unitOfWork.Paises.Add(registro);
        await _unitOfWork.Save();
        return CreatedAtAction(nameof(Post), new { id = registro.Id }, registro);
    }

    [HttpPut("{id}")]
    // [Authorize(Roles = "Administrador, Gerente")]
    // [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PaisDto>> Put(int id, [FromBody] PaisDto dataUpdate)
    {
        if(dataUpdate == null) return NotFound();
        var registro = _mapper.Map<Pais>(dataUpdate);
        registro.Id = id;
        _unitOfWork.Paises.Update(registro);
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
        var registro = await _unitOfWork.Paises.GetByIdAsync(id);
        if(registro == null) return NotFound();
        _unitOfWork.Paises.Remove(registro);
        await _unitOfWork.Save();
        return NoContent();
    }

    [HttpGet("pager")]
    // [Authorize]
    // [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<PaisDto>>> GetAreaWhithPage([FromQuery] Params parameters)
    {
        var registros = await _unitOfWork.Paises.GetAllAsync
        (
            parameters.PageIndex,
            parameters.PageSize,
            parameters.Search
        );
        var lstAreas = _mapper.Map<List<PaisDto>>(registros.registros);
        return new Pager<PaisDto>
        (
            lstAreas,
            registros.totalRegistros,
            parameters.PageIndex,
            parameters.PageSize,
            parameters.Search
        );
    }
}
