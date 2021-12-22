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
        public void Actualizar(Clientes clientes)
        {
             var query = "UPDATE Clientes SET CedulaCliente = @CedulaCliente, Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, Email = @Email, Direccion = @Direccion, VehiculoMatricula = @VehiculoMatricula, ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion WHERE CedulaCliente = CedulaCliente";
             var command = CreateCommand(query);


            command.Parameters.AddWithValue("@CedulaCliente", clientes.CedulaCliente);
            command.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            command.Parameters.AddWithValue("@Apellidos", clientes.Apellidos);
            command.Parameters.AddWithValue("@Telefono", clientes.Telefono);
            command.Parameters.AddWithValue("@Email", clientes.Email);
            command.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            command.Parameters.AddWithValue("@VehiculoMatricula", clientes.VehiculoMatricula);
            command.Parameters.AddWithValue("@ModificadoPor", clientes.ModificadoPor);
            command.Parameters.AddWithValue("@FechaModificacion", clientes.FechaModificacion);

            command.ExecuteNonQuery();

        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(Clientes clientes)
        {
            var query = "SP_Clientes_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CedulaCliente", clientes.CedulaCliente);
            command.Parameters.AddWithValue("@Nombre", clientes.Nombre);
            command.Parameters.AddWithValue("@Apellidos", clientes.Apellidos);
            command.Parameters.AddWithValue("@Telefono", clientes.Telefono);
            command.Parameters.AddWithValue("@Email", clientes.Email);
            command.Parameters.AddWithValue("@Direccion", clientes.Direccion);
            command.Parameters.AddWithValue("@VehiculoMatricula", clientes.VehiculoMatricula);
            command.Parameters.AddWithValue("@CreadoPor", clientes.CreadoPor);

            command.ExecuteNonQuery();

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

        public List<Clientes> SeleccionarTodos()
        {
            var query = "SELECT * FROM vwClientes_SeleccionarTodo";
            var comand = CreateCommand(query);

            SqlDataReader reader = comand.ExecuteReader();

            List<Clientes> lisClientes = new List<Clientes>();

            while (reader.Read())
            {
                Clientes clientesSelect = new();

                clientesSelect.CedulaCliente = Convert.ToString(reader["CedulaCliente"]);
                clientesSelect.Nombre = Convert.ToString(reader["Nombre"]);
                clientesSelect.Apellidos = Convert.ToString(reader["Apellidos"]);
                clientesSelect.Telefono = Convert.ToString(reader["Telefono"]);
                clientesSelect.Email = Convert.ToString(reader["Email"]);
                clientesSelect.Direccion = Convert.ToString(reader["Direccion"]);
                clientesSelect.VehiculoMatricula = Convert.ToString(reader["VehiculoMatricula"]);
                clientesSelect.Activo = Convert.ToBoolean(reader["Activo"]);
                clientesSelect.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                clientesSelect.FechaModificacion = (DateTime?)(reader.IsDBNull("FechaModificacion") ? null : reader["FechaModificacion"]);
                clientesSelect.CreadoPor = Convert.ToString(reader["CreadoPor"]);
                clientesSelect.ModificadoPor = Convert.ToString(reader["ModificadoPor"]);
            }
            reader.Close();

            return lisClientes;
        }
    }
}
