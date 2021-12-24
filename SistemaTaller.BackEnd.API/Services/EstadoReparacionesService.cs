using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class EstadoReparacionesService : IEstadoReparacionesService
    {
        private IUnitOfWork BD;
        public EstadoReparacionesService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }
        public void Actualizar(EstadoReparaciones model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(EstadoReparaciones model)
        {
            using var bd = BD.Conectar();
            {
                bd.Repositories.EstadoReparacionesRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public EstadoReparaciones SeleccionarPorId(string id)
        {
            EstadoReparaciones estadoSelect = new();
            using (var bd = BD.Conectar())
            {
                estadoSelect = bd.Repositories.EstadoReparacionesRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return estadoSelect;
        }

        public List<EstadoReparaciones> SeleccionarTodos()
        {
            List<EstadoReparaciones> lisEstadoReparaciones = new();

            using (var bd = BD.Conectar())
            {
                lisEstadoReparaciones = bd.Repositories.EstadoReparacionesRepository.SeleccionarTodos();
                bd.SaveChanges();
            }
            return lisEstadoReparaciones;
        }
    }
}
