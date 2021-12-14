﻿using SistemaTaller.BackEnd.API.Models;
using SistemaTaller.BackEnd.API.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.RepositorySQL
{
    public class VehiculosDeClientesRepository : ConexionDB, IVehiculosDeClientesRepository
    {
        public VehiculosDeClientesRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public void Actualizar(VehiculosDeClientes t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(VehiculosDeClientes vehiculosDeClientes)
        {
            var query = "SP_VehiculosDeClientes_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Matricula", vehiculosDeClientes.Matricula);
            command.Parameters.AddWithValue("@CedulaCliente", vehiculosDeClientes.CedulaCliente);
            command.Parameters.AddWithValue("@CreadoPor", vehiculosDeClientes.CreadoPor);

            command.ExecuteNonQuery();

        }

        public VehiculosDeClientes SeleccionarPorId(string Matricula)
        {
            var query = "SELECT * FROM vwVehiculosDeClientes_SeleccionarTodos WHERE Matricula = @Matricula";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@Matricula", Matricula);

            SqlDataReader reader = command.ExecuteReader();

            VehiculosDeClientes vehiculosDeClientesSelect = new();

            while (reader.Read())
            {
                vehiculosDeClientesSelect.Matricula = Convert.ToString(reader["Matricula"]);
                vehiculosDeClientesSelect.CedulaCliente = Convert.ToString(reader["CedulaCliente"]);
               
            }
            reader.Close();
            return vehiculosDeClientesSelect;
        }

        public IEnumerable<VehiculosDeClientes> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}