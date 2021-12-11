using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Repository.Interfaces.Actions
{
    public interface IInsertarRepository <T> where T : class
    {
        void Insertar(T t);
    }
}
