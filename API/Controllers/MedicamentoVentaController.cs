
using API.Dtos.MedicamentoVenta;
using API.Helpers;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MedicamentoVentaController : BaseApiController
    {
        public MedicamentoVentaController(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        [HttpGet("all")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<List<MedicamentoVentaDto>>> Get()
        {
            var registros = await _unitOfWork.MedicamentoVentas.GetAllAsync();
            if(registros == null) return NotFound();
            return _mapper.Map<List<MedicamentoVentaDto>>(registros);   
        }

        [HttpGet("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MedicamentoVentaDto>> GetById(int id)
        {
            var registro = await _unitOfWork.MedicamentoVentas.GetByIdAsync(id);
            if(registro == null) return NotFound(); 
            return _mapper.Map<MedicamentoVentaDto>(registro);
        }

        [HttpPost]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MedicamentoVentaDto>> Post(MedicamentoVentaDto data)
        {
            var registro = _mapper.Map<MedicamentoVenta >(data);
            if(registro == null) return BadRequest();
            _unitOfWork.MedicamentoVentas.Add(registro);
            await _unitOfWork.Save();
            return CreatedAtAction(nameof(Post), new { id = registro.Id }, registro);
        }

        [HttpPut("{id}")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MedicamentoVentaDto>> Put(int id, [FromBody] MedicamentoVentaDto dataUpdate)
        {
            if(dataUpdate == null) return NotFound();
            var registro = _mapper.Map<MedicamentoVenta >(dataUpdate);
            registro.Id = id;
            _unitOfWork.MedicamentoVentas.Update(registro);
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
            var registro = await _unitOfWork.MedicamentoVentas.GetByIdAsync(id);
            if(registro == null) return NotFound();
            _unitOfWork.MedicamentoVentas.Remove(registro);
            await _unitOfWork.Save();
            return NoContent();
        }

        [HttpGet("pager")]
        // [Authorize]
        // [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pager<MedicamentoVentaDto>>> GetAreaWhithPage([FromQuery] Params parameters)
        {
            var registros = await _unitOfWork.MedicamentoVentas.GetAllAsync
            (
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
            var lstAreas = _mapper.Map<List<MedicamentoVentaDto>>(registros.registros);
            return new Pager<MedicamentoVentaDto>
            (
                lstAreas,
                registros.totalRegistros,
                parameters.PageIndex,
                parameters.PageSize,
                parameters.Search
            );
        }

        [HttpGet("marzo")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<string>> GetTotalVentas()
        {
            var idRegistros = await _unitOfWork.Ventas.GetVentasMarzo();
            if(idRegistros == null) return NotFound();
            int totalMedicamentoVendidos = 0;
            foreach(int id in idRegistros)
            {
                var registro = await _unitOfWork.MedicamentoVentas.GetByIdVenta(id);
                var venta = _mapper.Map<MedicamentoVentaDto>(registro);
                totalMedicamentoVendidos += venta.Cantidad;
            }
            return $"El total de medicamento vendidos en marzo de 2023 es de : {totalMedicamentoVendidos}";
        }

        [HttpGet("noVentas")]
        // [Authorize(Roles = "Administrador, Gerente")]
        // [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<dynamic>> GetMedicamentosNoVendidos()
        {
            var registros = await _unitOfWork.MedicamentoVentas.GetMedicamentosNoVendidos();
            if(registros == null) return NotFound();
            return _mapper.Map<List<MedicamentoVentaDto>>(registros);  
        }
    }
}