using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repositories
{
    public class EstadoRepository : GenericRepository<Estado>, IEstado
    {
        private readonly WebApiContext _context;
    
        public EstadoRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}