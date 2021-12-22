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
    public class EstadoReparacionesRepository : ConexionDB, IEstadoReparacionesRepository
    {
        public EstadoReparacionesRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public void Actualizar(EstadoReparaciones t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(EstadoReparaciones estadoReparaciones)
        {
            var query = "SP_EstadoReparaciones_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@IdEstadoReparacion", estadoReparaciones.IdEstadoReparacion);
            command.Parameters.AddWithValue("@NombreEstado", estadoReparaciones.NombreEstado);
            command.Parameters.AddWithValue("@CreadoPor", estadoReparaciones.CreadoPor);

            command.ExecuteNonQuery();

        }

        public EstadoReparaciones SeleccionarPorId(string IdEstadoReparacion)
        {
            var query = "SELECT * FROM vwEstadoDeReparaciones_SeleccionarTodo WHERE IdEstadoReparacion = @IdEstadoReparacion";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@IdEstadoReparacion", IdEstadoReparacion);

            SqlDataReader reader = command.ExecuteReader();
            EstadoReparaciones estadoSelect = new();

            while (reader.Read())
            {
                estadoSelect.IdEstadoReparacion = Convert.ToInt32(reader["IdEstadoReparacion"]);
                estadoSelect.NombreEstado = Convert.ToString(reader["NombreEstado"]);

            }
            reader.Close();
            return estadoSelect;
        }

        public List<EstadoReparaciones> SeleccionarTodos()
        {
            var query = "SELECT * FROM vwEstadoDeReparaciones_SeleccionarTodo";
            var command = CreateCommand(query);            

            SqlDataReader reader = command.ExecuteReader();

            List<EstadoReparaciones> lisEstadoReparaciones = new List<EstadoReparaciones>();

            while (reader.Read())
            {
                EstadoReparaciones estadoSelect = new();
                estadoSelect.IdEstadoReparacion = Convert.ToInt32(reader["IdEstadoReparacion"]);
                estadoSelect.NombreEstado = Convert.ToString(reader["NombreEstado"]);
                estadoSelect.Activo = Convert.ToBoolean(reader["Activo"]);
                estadoSelect.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                estadoSelect.FechaModificacion = (DateTime?)(reader.IsDBNull("FechaModificacion") ? null : reader["FechaModificacion"]);
                estadoSelect.CreadoPor = Convert.ToString(reader["CreadoPor"]);
                estadoSelect.ModificadoPor = Convert.ToString(reader["ModificadoPor"]);

            }
            reader.Close();
            return lisEstadoReparaciones;
        }
    }
}
