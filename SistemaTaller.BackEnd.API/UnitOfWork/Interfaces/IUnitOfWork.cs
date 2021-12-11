using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IUnitOfWorkAdapter Conectar();
    }
}
