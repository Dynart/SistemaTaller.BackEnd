
using SistemaTaller.BackEnd.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.UnitOfWork.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IVehiculosRepository VehiculosRepository { get; }
        IClientesRepository ClientesRepository {get;}
        IMecanicosRepository MecanicosRepository { get; }
        ITalleresRepository TalleresRepository { get; }
        IMecanicosDeTalleresRepository MecanicosDeTalleresRepository { get; }
        IVehiculosDeClientesRepository VehiculosDeClientesRepository { get; }
        IRepuestosRepository RepuestosRepository { get; }
        IEstadoReparacionesRepository EstadoReparacionesRepository { get; }
        IReparacionesRepository ReparacionesRepository { get; }
        IRepuestosDeReparacionesRepository RepuestosDeReparacionesRepository { get; }
    }
}
