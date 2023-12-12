using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Entities.Querys;

namespace Dominio.Interfaces
{
    public interface IPersona : IGenericRepository<Persona>
    {   
        Task<IEnumerable<EmpleadoVigilante>> GetEmpleadosVigilantes();
        Task<IEnumerable<EmpleadosEmpresa>> GetEmpleadosOfCompany();
        Task<EmpleadoNumeros> GetContactNumbersOfOneEmployee();
        Task<IEnumerable<Clientes5AñosAntiguedad>> GetClientsWithFiveYearsPast();
    }
}