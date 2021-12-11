using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class TalleresService : ITalleresService
    {

        private IUnitOfWork BD;
        public TalleresService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(Talleres model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Talleres model)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.TalleresRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public Talleres SeleccionarPorId(string id)
        {
            Talleres talleresSelect = new();
            using (var bd = BD.Conectar())
            {
                talleresSelect = bd.Repositories.TalleresRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return talleresSelect;
        }

        public IEnumerable<Talleres> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
