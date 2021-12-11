using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
   public interface IMecanicosService
    {
        IEnumerable<Mecanicos> SeleccionarTodos();
        Mecanicos SeleccionarPorId(string id);
        void Insertar(Mecanicos model);
        void Actualizar(Mecanicos model);
        void Eliminar(int id);
    }
}
