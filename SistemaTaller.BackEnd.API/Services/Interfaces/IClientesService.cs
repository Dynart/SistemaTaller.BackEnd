using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IClientesService
    {
        List<Clientes> SeleccionarTodos();
        Clientes SeleccionarPorId(string id);
        void Insertar(Clientes model);
        void Actualizar(Clientes model);
        void Eliminar(int id);
    }
}
