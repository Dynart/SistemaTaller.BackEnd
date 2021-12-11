using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Repository.Interfaces.Actions
{
    public interface IObtenerRepository <T, Y> where T : class
    {
        IEnumerable<T> SeleccionarTodos();
        T SeleccionarPorId(Y id);
    }
}
