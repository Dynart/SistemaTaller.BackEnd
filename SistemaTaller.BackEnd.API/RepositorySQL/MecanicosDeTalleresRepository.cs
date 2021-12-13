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
    public class MecanicosDeTalleresRepository : ConexionDB, IMecanicosDeTalleresRepository
    {
        public MecanicosDeTalleresRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public void Actualizar(MecanicosDeTalleres t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(MecanicosDeTalleres mecanicosDeTalleres)
        {
            var query = "SP_MecanicosDeTalleres_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CedulaMecanico", mecanicosDeTalleres.CedulaMecanico);
            command.Parameters.AddWithValue("@CedulaJuridica", mecanicosDeTalleres.CedulaJuridica);
            command.Parameters.AddWithValue("@CreadoPor", mecanicosDeTalleres.CreadoPor);

        }

        public MecanicosDeTalleres SeleccionarPorId(string CedulaMecanico)
        {
            var query = "	SELECT * FROM vwMecanicosDeTalleres_SeleccionarTodo WHERE CedulaMecanico = @CedulaMecanico";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue(@"CedulaMecanico", CedulaMecanico);

            SqlDataReader reader = command.ExecuteReader();

            MecanicosDeTalleres mecanicosTalleresSelect = new();

            while (reader.Read())
            {
                mecanicosTalleresSelect.CedulaMecanico = Convert.ToString(reader["CedulaMecanico"]);
                mecanicosTalleresSelect.CedulaJuridica = Convert.ToString(reader["CedulaJuridica"]);

            }

            reader.Close();

            return mecanicosTalleresSelect;
        }

        public IEnumerable<MecanicosDeTalleres> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
