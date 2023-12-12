using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Data;
using Dominio.Entities;
using Dominio.Interfaces;

namespace Aplicacion.Repositories
{
    public class TipoDireccionRepository : GenericRepository<Tipodireccion>, ITipoDireccion
    {
        private readonly WebApiContext _context;
    
        public TipoDireccionRepository(WebApiContext context) : base(context)
        {
            _context = context;
        }
    }
}