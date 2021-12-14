using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IVehiculosDeClientesService
    {
        IEnumerable<VehiculosDeClientes> SeleccionarTodos();
        VehiculosDeClientes SeleccionarPorId(string id);
        void Insertar(VehiculosDeClientes model);
        void Actualizar(VehiculosDeClientes model);
        void Eliminar(int id);
    }
}
