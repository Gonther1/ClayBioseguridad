using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities.Querys
{
    public class EmpleadoNumeros
    {
        public string Nombre { get; set; }
        public IEnumerable<object> NumerosDeContacto { get; set; }

    }
}