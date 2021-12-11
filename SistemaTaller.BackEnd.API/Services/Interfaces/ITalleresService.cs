using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
   public interface ITalleresService
    {
        IEnumerable<Talleres> SeleccionarTodos();
        Talleres SeleccionarPorId(string id);
        void Insertar(Talleres model);
        void Actualizar(Talleres model);
        void Eliminar(int id);
    }
}
