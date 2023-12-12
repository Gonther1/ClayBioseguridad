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
    public class ContratoRepository : GenericRepository<Contrato>, IContrato
    {
        private readonly WebApiContext _context;
    
        public ContratoRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ContratosActivos>> GetActiveContracts()
        {
            return await (from cont in _context.Contratos
                         join est in _context.Estados
                         on cont.IdEstadoFk equals est.Id
                         where est.Id == 1
                         join cli in _context.Personas
                         on cont.IdClienteFk equals cli.Id
                         where cli.Id == 1
                         join emp in _context.Personas
                         on cont.IdEmpleadoFk equals emp.IdPersonaFk
                         where emp.Id == 2
                         select new ContratosActivos 
                         {
                            IdContrato = cont.Id,
                            EstadoContrato = est.Descripcion,
                            NombreCliente = cli.Nombre,
                            NombreEmpleado = emp.Nombre
                         }
            ).ToListAsync();
        }
    }
}