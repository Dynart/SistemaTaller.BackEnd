using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class MecanicosDeTalleresService : IMecanicosDeTalleresService
    {
        private IUnitOfWork BD;
        public MecanicosDeTalleresService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(MecanicosDeTalleres model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(MecanicosDeTalleres model)
        {
            using (var bd = BD.Conectar())
            {
                bd.Repositories.MecanicosDeTalleresRepository.Insertar(model);
                bd.SaveChanges();
            }
        }

        public MecanicosDeTalleres SeleccionarPorId(string id)
        {
            MecanicosDeTalleres mecanicosTalleresSelect = new();
            using (var bd = BD.Conectar())
            {
                mecanicosTalleresSelect = bd.Repositories.MecanicosDeTalleresRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return mecanicosTalleresSelect;
        }

        public IEnumerable<MecanicosDeTalleres> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
