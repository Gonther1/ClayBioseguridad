using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.Entities.Querys;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    public class ConsultsController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ConsultsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // 1

        [HttpGet("1-GetAllEmpleadosOfCompany")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EmpleadosEmpresa>>> GetAllEmpleadosOfCompany()
        {
            var entity = await _unitOfWork.Personas.GetEmpleadosOfCompany();
            return _mapper.Map<List<EmpleadosEmpresa>>(entity);
        }

        // 2

        [HttpGet("2-VigilantEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<EmpleadoVigilante>>> GetVigilantEmployees()
        {
            var entity = await _unitOfWork.Personas.GetEmpleadosVigilantes();
            return _mapper.Map<List<EmpleadoVigilante>>(entity);
        }

        // 3

        [HttpGet("3-NumerosEmpleado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmpleadoNumeros>> NumerosEmpleado()
        {
            var entity = await _unitOfWork.Personas.GetContactNumbersOfOneEmployee();
            return _mapper.Map<EmpleadoNumeros>(entity);
        }

        // 4

        [HttpGet("4-GetClientsOfBucaramanga")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ClientesBucaramanga>>> GetClientsOfBucaramanga()
        {
            var entity = await _unitOfWork.Ciudades.GetClientesFromBucaramanga();
            return _mapper.Map<List<ClientesBucaramanga>>(entity);
        }

        // 5

        [HttpGet("5-GetClientsFromGironAndPiedecuesta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ClientesBucaramanga>>> GetClientsFromGironAndPiedecuesta()
        {
            var entity = await _unitOfWork.Ciudades.GetClientesPiedecuestaAndGiron();
            return _mapper.Map<List<ClientesBucaramanga>>(entity);
        }
        
        // 6

        [HttpGet("6-GetClientsWithFiveYearPast")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Clientes5AñosAntiguedad>>> GetClientsWithFiveYearPast()
        {
            var entity = await _unitOfWork.Personas.GetClientsWithFiveYearsPast();
            return _mapper.Map<List<Clientes5AñosAntiguedad>>(entity);
        }

        // 7

        [HttpGet("7-ActiveContracts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ContratosActivos>>> ActiveContracts()
        {
            var entity = await _unitOfWork.Contratos.GetActiveContracts();
            return _mapper.Map<List<ContratosActivos>>(entity);
        }
    }
}