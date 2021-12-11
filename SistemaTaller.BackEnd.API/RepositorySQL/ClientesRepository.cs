using SistemaTaller.BackEnd.API.DTOS;
using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.RepositorySQL
{
    public class ClientesRepository : ConexionDB, IClientesRepository
    {
        public ClientesRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public void Actualizar(Clientes t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(Clientes clientes)
        {
            var query = "SP_Clientes_Insert";
            var comand = CreateCommand(query);

            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.AddWithValue("@CedulaCliente", clientes.CedulaCliente);
            comand.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            comand.Parameters.AddWithValue("@Apellidos", clientes.Apellidos);
            comand.Parameters.AddWithValue("@Telefono", clientes.Telefono);
            comand.Parameters.AddWithValue("@Email", clientes.Email);
            comand.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            comand.Parameters.AddWithValue("@VehiculoMatricula", clientes.VehiculoMatricula);
            comand.Parameters.AddWithValue("@CreadoPor", clientes.CreadoPor);

            comand.ExecuteNonQuery();

        }

        public Clientes SeleccionarPorId(string CedulaCliente)
        {
            var query = "SELECT * FROM vwClientes_SeleccionarTodo WHERE CedulaCliente = @CedulaCliente";
            var comand = CreateCommand(query);

            comand.Parameters.AddWithValue("@CedulaCliente", CedulaCliente);

            SqlDataReader reader = comand.ExecuteReader();
            Clientes clientesSelect = new();

            while (reader.Read())
            {
                clientesSelect.CedulaCliente = Convert.ToString(reader["CedulaCliente"]);
                clientesSelect.Nombre = Convert.ToString(reader["Nombre"]);
                clientesSelect.Apellidos = Convert.ToString(reader["Apellidos"]);
                clientesSelect.Telefono = Convert.ToString(reader["Telefono"]);
                clientesSelect.Email = Convert.ToString(reader["Email"]);
                clientesSelect.Direccion = Convert.ToString(reader["Direccion"]);
                clientesSelect.VehiculoMatricula = Convert.ToString(reader["VehiculoMatricula"]);

            }
            reader.Close();

            return clientesSelect;
        }

        public IEnumerable<Clientes> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
