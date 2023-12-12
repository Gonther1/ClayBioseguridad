using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities.Querys
{
    public class EmpleadosEmpresa
    {
        public string Nombre { get; set; }
        public string TipoPersona { get; set; }
        public int ?IdEmpleadoFk { get; set; }
        public int IdPersona { get; set; }
        public DateOnly? FechaContrato { get; set; }
    }
}