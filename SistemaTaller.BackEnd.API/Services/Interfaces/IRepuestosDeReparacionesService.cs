using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IRepuestosDeReparacionesService
    {
        List<RepuestosDeReparaciones> SeleccionarTodos();
        RepuestosDeReparaciones SeleccionarPorId(string id);
        void Insertar(RepuestosDeReparaciones model);
        void Actualizar(RepuestosDeReparaciones model);
        void Eliminar(int id);
    }
}
