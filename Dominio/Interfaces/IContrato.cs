using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Entities.Querys;

namespace Dominio.Interfaces
{
    public interface IContrato : IGenericRepository<Contrato>
    {   
        Task<IEnumerable<ContratosActivos>> GetActiveContracts();
    }
}