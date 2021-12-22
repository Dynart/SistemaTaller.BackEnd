using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IReparacionesService
    {
        List<Reparaciones> SeleccionarTodos();
        Reparaciones SeleccionarPorId(string id);
        void Insertar(Reparaciones model);
        void Actualizar(Reparaciones model);
        void Eliminar(int id);
    }
}
