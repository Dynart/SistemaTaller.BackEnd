using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IVehiculosService
    {
        List<Vehiculos> SeleccionarTodos();
        Vehiculos SeleccionarPorId(string id);
        void Insertar(Vehiculos model);
        void Actualizar(Vehiculos model);
        void Eliminar(int id);
    }
}
