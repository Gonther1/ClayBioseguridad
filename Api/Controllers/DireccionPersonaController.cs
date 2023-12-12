using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class DireccionPersonaController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DireccionPersonaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DireccionPersonaDto>>> Get()
        {
            var entity = await _unitOfWork.Direccionespersonas.GetAllAsync();
            return _mapper.Map<List<DireccionPersonaDto>>(entity);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Direccionpersona>> Post(DireccionPersonaDto entityDto)
        {
            var entity = _mapper.Map<Direccionpersona>(entityDto);
        /*
            if (entity.FechaCreacion == DateTime.MinValue)
            {
                entity.FechaCreacion = DateTime.Now;
                entityDto.FechaCreacion = DateTime.Now;
            }
            if (entity.FechaModificacion == DateTime.MinValue)
            {
                entity.FechaModificacion = DateTime.Now;
                entityDto.FechaModificacion = DateTime.Now;
            }
        */
            _unitOfWork.Direccionespersonas.Add(entity);
            await _unitOfWork.SaveAsync();
            if (entity == null)
            {
                return BadRequest();
            }
            entityDto.Id = entity.Id;
            return CreatedAtAction(nameof(Post), new { id = entityDto.Id }, entityDto);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DireccionPersonaDto>> Get(int id)
        {
            var entity = await _unitOfWork.Direccionespersonas.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return _mapper.Map<DireccionPersonaDto>(entity);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DireccionPersonaDto>> Put(int id, [FromBody] DireccionPersonaDto entityDto)
        {
            var entity = _mapper.Map<Direccionpersona>(entityDto);
            if (entity.Id == 0)
            {
                entity.Id = id;
            }
            if (entity.Id != id)
            {
                return BadRequest();
            }
            if (entity == null)
            {
                return NotFound();
            }
        /*
            if (entity.FechaCreacion == DateTime.MinValue)
            {
                entity.FechaCreacion = DateTime.Now;
                entityDto.FechaCreacion = DateTime.Now;
            }
            if (entity.FechaModificacion == DateTime.MinValue)
            {
                entity.FechaModificacion = DateTime.Now;
                entityDto.FechaModificacion = DateTime.Now;
            }
        */
            entityDto.Id = entity.Id;
            _unitOfWork.Direccionespersonas.Update(entity);
            await _unitOfWork.SaveAsync();
            return entityDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(int id)
        {
            var entity = await _unitOfWork.Direccionespersonas.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            _unitOfWork.Direccionespersonas.Remove(entity);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}