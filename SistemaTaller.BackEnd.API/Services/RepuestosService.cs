using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class RepuestosService : IRepuestosService
    {
        private IUnitOfWork BD;
        public RepuestosService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(Repuestos model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Repuestos model)
        {
            using var bd = BD.Conectar();
            {
                bd.Repositories.RepuestosRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public Repuestos SeleccionarPorId(string id)
        {
            Repuestos repuestosSelect = new();
            using (var bd = BD.Conectar())
            {
                repuestosSelect = bd.Repositories.RepuestosRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return repuestosSelect;
        }

        public IEnumerable<Repuestos> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
