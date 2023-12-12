using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities.Querys
{
    public class Clientes5AñosAntiguedad
    {
        public string NombreCliente { get; set; }
        public string TipoPersona { get; set; }
        public DateOnly? FechaRegistro { get; set; }
        public DateOnly? FechaHoy { get; set; }
        public int Year { get; set; }
    }
}