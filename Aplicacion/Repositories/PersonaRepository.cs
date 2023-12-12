using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Entities.Querys;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repositories
{
    public class PersonaRepository : GenericRepository<Persona>, IPersona
    {
        private readonly WebApiContext _context;
    
        public PersonaRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }

        // 1

        public async Task<IEnumerable<EmpleadosEmpresa>> GetEmpleadosOfCompany()
        {
            return await (from p in _context.Personas
                         join typePer in _context.Tipopersonas
                         on p.IdTipoPersonaFk equals typePer.Id 
                         where typePer.Id == 2
                         join cont in _context.Contratos
                         on p.Id equals cont.IdEmpleadoFk
                         select new EmpleadosEmpresa
                         {
                            Nombre = p.Nombre,
                            TipoPersona = typePer.Descripcion,
                            IdPersona = p.Id,
                            IdEmpleadoFk = cont.IdEmpleadoFk,
                            FechaContrato = cont.FechaContrato                   
                         }
                         
                         ).ToListAsync();
        }

        // 2

        public async Task<IEnumerable<EmpleadoVigilante>> GetEmpleadosVigilantes()
        {
            return await (from p in _context.Personas
                         join typePer in _context.Tipopersonas
                         on p.IdTipoPersonaFk equals typePer.Id 
                         where typePer.Id == 2
                         join catPer in _context.Categoriapersonas
                         on p.IdCategoriaFk equals catPer.Id
                         where catPer.Id == 1   
                         select new EmpleadoVigilante
                         {
                            Nombre = p.Nombre,
                            TipoPersona = typePer.Descripcion,
                            Cargo = catPer.Nombre
                         }
            ).ToListAsync();
        }

        public async Task<EmpleadoNumeros> GetContactNumbersOfOneEmployee()
        {
            return await (from p in _context.Personas
                         join conPer in _context.Contactopersonas
                         on p.Id equals conPer.IdPersonaFk 
                         join typeContact in _context.Tipocontactos
                         on conPer.IdTipoContactoFk equals typeContact.Id
                         where typeContact.Id == 1 || typeContact.Id == 2
                        group new { p, conPer } by new { p.Id, p.Nombre } into grouped
                        select new EmpleadoNumeros
                        {
                            Nombre = grouped.Key.Nombre,
                            NumerosDeContacto = grouped.Select(x => x.conPer.Descripcion).ToList()  
                        }
            ).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Clientes5AñosAntiguedad>> GetClientsWithFiveYearsPast()
        {
            return await (from cli in _context.Personas
                         join typePerson in _context.Tipopersonas
                         on cli.IdTipoPersonaFk equals typePerson.Id
                         where cli.IdTipoPersonaFk == 1 && cli.FechaRegistro <= DateOnly.FromDateTime(DateTime.Now).AddYears(-5)
                         select new Clientes5AñosAntiguedad
                         {
                            NombreCliente = cli.Nombre,
                            TipoPersona = typePerson.Descripcion,
                            FechaRegistro = cli.FechaRegistro,
                            FechaHoy = DateOnly.FromDateTime(DateTime.Now) // Mostrar la fecha unicamente sin la hora
                         }
            ).ToListAsync();
        }
    }
}