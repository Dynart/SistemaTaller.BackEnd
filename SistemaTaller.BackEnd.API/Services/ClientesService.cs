using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Services.Interfaces;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.Services
{
    public class ClientesService : IClientesService
    {
        private IUnitOfWork BD;
        public ClientesService(IUnitOfWork unitOfWork)
        {
            BD = unitOfWork;
        }

        public void Actualizar(Clientes model)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Clientes model)
        {
            using var bd = BD.Conectar();
            {
                bd.Repositories.ClientesRepository.Insertar(model);
                bd.SaveChanges();
            }

        }

        public Clientes SeleccionarPorId(string id)
        {
            Clientes clientesSelect = new();
            using (var bd = BD.Conectar())
            {
                clientesSelect = bd.Repositories.ClientesRepository.SeleccionarPorId(id);
                bd.SaveChanges();
            }
            return clientesSelect;
        }

        public IEnumerable<Clientes> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
