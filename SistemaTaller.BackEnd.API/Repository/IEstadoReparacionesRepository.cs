using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Repository.Interfaces.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Repository
{
    public interface IEstadoReparacionesRepository : IObtenerRepository<EstadoReparaciones, string>, IInsertarRepository<EstadoReparaciones>, IActualizarRepository<EstadoReparaciones>, IEliminarRepository<string>
    {

    }
}
