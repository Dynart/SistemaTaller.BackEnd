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
    public class TalleresRepository : ConexionDB, ITalleresRepository
    {
        public TalleresRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public void Actualizar(Talleres t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(Talleres talleres)
        {
            var query = "SP_Talleres_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CedulaJuridica", talleres.CedulaJuridica);
            command.Parameters.AddWithValue("@Nombre", talleres.Nombre);
            command.Parameters.AddWithValue("@Direccion", talleres.Direccion);
            command.Parameters.AddWithValue("@Telefono", talleres.Telefono);
            command.Parameters.AddWithValue("@CreadoPor", talleres.CreadoPor);

            command.ExecuteNonQuery();

        }

        public Talleres SeleccionarPorId(string CedulaJuridica)
        {
            var query = "SELECT * FROM vwTalleres_SeleccionarTodo WHERE CedulaJuridica = @CedulaJuridica";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@CedulaJuridica", CedulaJuridica);

            SqlDataReader reader = command.ExecuteReader();

            Talleres talleresSelect = new();

            while (reader.Read())
            {
                talleresSelect.CedulaJuridica = Convert.ToString(reader["CedulaJuridica"]);
                talleresSelect.Nombre = Convert.ToString(reader["Nombre"]);
                talleresSelect.Direccion = Convert.ToString(reader["Direccion"]);
                talleresSelect.Telefono = Convert.ToString(reader["Telefono"]);
            }

            reader.Close();

            return talleresSelect;
        }

        public IEnumerable<Talleres> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
