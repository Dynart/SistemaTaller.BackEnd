using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IRepuestosService
    {
        List<Repuestos> SeleccionarTodos();
        Repuestos SeleccionarPorId(string id);
        void Insertar(Repuestos model);
        void Actualizar(Repuestos model);
        void Eliminar(int id);
    }
}
