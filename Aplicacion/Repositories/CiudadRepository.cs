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
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudad
    {
        private readonly WebApiContext _context;
    
        public CiudadRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }

        // 4
        public async Task<IEnumerable<ClientesBucaramanga>> GetClientesFromBucaramanga()
        {
            return await (from ciu in _context.Ciudads
                         join per in _context.Personas
                         on ciu.Id equals per.IdCiudadFk
                         where per.IdCiudadFk == 1
                         join typePerson in _context.Tipopersonas
                         on per.IdTipoPersonaFk equals typePerson.Id
                         where typePerson.Id == 1
                         select new ClientesBucaramanga 
                         {
                            NombreCliente = per.Nombre,
                            TipoPersona = typePerson.Descripcion,
                            Ciudad = ciu.Nombre
                         }
            ).ToListAsync();
        }

        // 5

        public async Task<IEnumerable<ClientesBucaramanga>> GetClientesPiedecuestaAndGiron()
        {
            return await (from ciu in _context.Ciudads
                         join per in _context.Personas
                         on ciu.Id equals per.IdCiudadFk
                         where per.IdCiudadFk == 2 || per.IdCiudadFk == 3
                         join typePerson in _context.Tipopersonas
                         on per.IdTipoPersonaFk equals typePerson.Id
                         where typePerson.Id == 1
                         select new ClientesBucaramanga 
                         {
                            NombreCliente = per.Nombre,
                            TipoPersona = typePerson.Descripcion,
                            Ciudad = ciu.Nombre
                         }
            ).ToListAsync();
        }
    }
}