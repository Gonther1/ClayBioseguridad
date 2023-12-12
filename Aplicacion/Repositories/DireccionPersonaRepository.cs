using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repositories
{
    public class DireccionPersonaRepository : GenericRepository<Direccionpersona>, IDireccionPersona
    {
        private readonly WebApiContext _context;
    
        public DireccionPersonaRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}