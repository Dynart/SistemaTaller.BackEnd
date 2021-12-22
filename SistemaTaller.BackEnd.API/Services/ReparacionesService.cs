using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class ReparacionesService : IReparacionesService
    {
        private IUnitOfWork BD;
        public ReparacionesService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(Reparaciones model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Reparaciones model)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.ReparacionesRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public Reparaciones SeleccionarPorId(string id)
        {
            Reparaciones reparacionesSelect = new();
            using(var bd = BD.Conectar())
            {
                reparacionesSelect = bd.Repositories.ReparacionesRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return reparacionesSelect;
        }

        public List<Reparaciones> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
