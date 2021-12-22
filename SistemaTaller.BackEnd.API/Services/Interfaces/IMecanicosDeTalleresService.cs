using SistemaTaller.BackEnd.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services.Interfaces
{
    public interface IMecanicosDeTalleresService
    {
        List<MecanicosDeTalleres> SeleccionarTodos();
        MecanicosDeTalleres SeleccionarPorId(string id);
        void Insertar(MecanicosDeTalleres model);
        void Actualizar(MecanicosDeTalleres model);
        void Eliminar(int id);
    }
}
