
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
    }
}
