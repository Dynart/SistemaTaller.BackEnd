
using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class MecanicosService : IMecanicosService
    {
        private IUnitOfWork BD;
        public MecanicosService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(Mecanicos model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Mecanicos model)
        {
            using var bd = BD.Conectar();
            {
                bd.Repositories.MecanicosRepository.Insertar(model);
                bd.SaveChanges();
            }

        }

        public Mecanicos SeleccionarPorId(string id)
        {
            Mecanicos mecanicosSelect = new();

            using (var bd = BD.Conectar())
            {
                mecanicosSelect = bd.Repositories.MecanicosRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return mecanicosSelect;
        }

        public List<Mecanicos> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
