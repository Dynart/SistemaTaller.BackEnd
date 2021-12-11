using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Repository.Interfaces.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Repository
{
    public interface IVehiculosRepository : IObtenerRepository <Vehiculos, string> , IInsertarRepository<Vehiculos>, IActualizarRepository<Vehiculos>, IEliminarRepository<string>
    {
    }
}
