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
    public class MecanicosRepository : ConexionDB, IMecanicosRepository
    {
        public MecanicosRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public void Actualizar(Mecanicos t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(Mecanicos mecanicos)
        {
            var query = "SP_Mecanicos_Insert";
            var comand = CreateCommand(query);

            comand.CommandType = CommandType.StoredProcedure;

            comand.Parameters.AddWithValue("@CedulaMecanico", mecanicos.CedulaMecanico);
            comand.Parameters.AddWithValue("@Nombre", mecanicos.Nombre);
            comand.Parameters.AddWithValue("@Apellidos", mecanicos.Apellidos);
            comand.Parameters.AddWithValue("@Telefono", mecanicos.Telefono);
            comand.Parameters.AddWithValue("@Salario", mecanicos.Salario);
            comand.Parameters.AddWithValue("@CreadoPor", mecanicos.CreadoPor);

            comand.ExecuteNonQuery();

        }

        public Mecanicos SeleccionarPorId(string CedulaMecanico)
        {
            var query = "SELECT * FROM vwMecanicos_SeleccionarTodo WHERE CedulaMecanico = @CedulaMecanico";
            var comand = CreateCommand(query);

            comand.Parameters.AddWithValue("@CedulaMecanico", CedulaMecanico);

            SqlDataReader reader = comand.ExecuteReader();
            Mecanicos mecanicosSelect = new();

            while (reader.Read())
            {
                mecanicosSelect.CedulaMecanico = Convert.ToString(reader["CedulaMecanico"]);
                mecanicosSelect.Nombre = Convert.ToString(reader["Nombre"]);
                mecanicosSelect.Apellidos = Convert.ToString(reader["Apellidos"]);
                mecanicosSelect.Telefono = Convert.ToString(reader["Telefono"]);
                mecanicosSelect.Salario = Convert.ToDecimal(reader["Salario"]);


            }
            reader.Close();

            return mecanicosSelect;
        }

        public IEnumerable<Mecanicos> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
