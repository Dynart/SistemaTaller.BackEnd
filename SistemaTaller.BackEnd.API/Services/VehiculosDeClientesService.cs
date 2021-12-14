using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class VehiculosDeClientesService : IVehiculosDeClientesService
    {
        private IUnitOfWork BD;
        public VehiculosDeClientesService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(VehiculosDeClientes model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(VehiculosDeClientes model)
        {
           using (var bd = BD.Conectar())
            {
                bd.Repositories.VehiculosDeClientesRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public VehiculosDeClientes SeleccionarPorId(string id)
        {
            VehiculosDeClientes vehiculosDeClientesSelect = new();
            using (var bd = BD.Conectar())
            {
                vehiculosDeClientesSelect = bd.Repositories.VehiculosDeClientesRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return vehiculosDeClientesSelect;
        }

        public IEnumerable<VehiculosDeClientes> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
