
using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class VehiculosService : IVehiculosService
    {
        private IUnitOfWork BD;
        public VehiculosService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }
        public void Actualizar(Vehiculos model)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.VehiculosRepository.Actualizar(model);

                bd.SaveChanges();

            }
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Vehiculos model)
        {
            using var bd = BD.Conectar();
            {
                bd.Repositories.VehiculosRepository.Insertar(model);

                bd.SaveChanges();
            }
        }

        public Vehiculos SeleccionarPorId(string id)
        {
            Vehiculos vehiculosSelect = new();

            using (var bd = BD.Conectar())
            {
                vehiculosSelect = bd.Repositories.VehiculosRepository.SeleccionarPorId(id);
                bd.SaveChanges();

            }
            return vehiculosSelect;
        }

        public List<Vehiculos> SeleccionarTodos()
        {
            List<Vehiculos> vehiculosList = new ();

            using(var bd = BD.Conectar())
            {
                vehiculosList = bd.Repositories.VehiculosRepository.SeleccionarTodos();
                bd.SaveChanges();
            }
            return vehiculosList;
        }
    }
}
