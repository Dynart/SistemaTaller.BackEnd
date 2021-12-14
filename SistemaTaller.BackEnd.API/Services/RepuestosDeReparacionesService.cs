using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class RepuestosDeReparacionesService : IRepuestosDeReparacionesService
    {
        private IUnitOfWork BD;
        public RepuestosDeReparacionesService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }


        public void Actualizar(RepuestosDeReparaciones model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(RepuestosDeReparaciones model)
        {
            using(var bd = BD.Conectar())
            {
                bd.Repositories.RepuestosDeReparacionesRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public RepuestosDeReparaciones SeleccionarPorId(string id)
        {
            RepuestosDeReparaciones repuestoSelect = new();
            using (var bd = BD.Conectar())
            {
                repuestoSelect = bd.Repositories.RepuestosDeReparacionesRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return repuestoSelect;
        }

        public IEnumerable<RepuestosDeReparaciones> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
