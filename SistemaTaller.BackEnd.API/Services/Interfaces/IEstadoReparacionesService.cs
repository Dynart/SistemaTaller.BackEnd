using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
   public interface IEstadoReparacionesService
    {
        IEnumerable<EstadoReparaciones> SeleccionarTodos();
        EstadoReparaciones SeleccionarPorId(string id);
        void Insertar(EstadoReparaciones model);
        void Actualizar(EstadoReparaciones model);
        void Eliminar(int id);
    }
}
