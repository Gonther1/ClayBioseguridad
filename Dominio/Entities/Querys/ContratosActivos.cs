using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities.Querys
{
    public class ContratosActivos
    {
        public int IdContrato { get; set; }
        public string EstadoContrato { get; set; }
        public string NombreCliente { get; set; }
        public string NombreEmpleado { get; set; }
    }
}