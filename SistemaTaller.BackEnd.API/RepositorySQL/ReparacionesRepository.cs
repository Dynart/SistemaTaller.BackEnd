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
    public class ReparacionesRepository : ConexionDB, IReparacionesRepository
    {
        public ReparacionesRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
      
        public void Actualizar(Reparaciones t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(Reparaciones reparaciones)
        {
            var query = "SP_Reparaciones_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            
            command.Parameters.AddWithValue("@MontoManoDeObra", reparaciones.MontoManoDeObra);
            command.Parameters.AddWithValue("@MontoRepuestos", reparaciones.MontoRepuestos);
            command.Parameters.AddWithValue("@CedulaMecanico", reparaciones.CedulaMecanico);
            command.Parameters.AddWithValue("@Matricula", reparaciones.Matricula);
            command.Parameters.AddWithValue("@IdEstadoReparacion", reparaciones.IdEstadoReparacion);
            command.Parameters.AddWithValue("@CreadoPor", reparaciones.CreadoPor);

            command.ExecuteNonQuery();

        }

        public Reparaciones SeleccionarPorId(string NumeroReparacion)
        {
            var query = "SELECT * FROM vwReparaciones_SeleccionarTodo WHERE NumeroReparacion = @NumeroReparacion";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@NumeroReparacion", NumeroReparacion);

            SqlDataReader reader = command.ExecuteReader();
            Reparaciones reparacionesSelect = new();

            while (reader.Read())
            {
                reparacionesSelect.NumeroReparacion = Convert.ToInt32(reader["NumeroReparacion"]);
                reparacionesSelect.FechaEstimadaDeReparacion = Convert.ToDateTime(reader["FechaEstimadaDeReparacion"]);
                reparacionesSelect.MontoManoDeObra = Convert.ToDecimal(reader["MontoManoDeObra"]);
                reparacionesSelect.MontoRepuestos = Convert.ToDecimal(reader["MontoRepuestos"]);
                reparacionesSelect.MontoTotal = Convert.ToDecimal(reader["MontoTotal"]);
                reparacionesSelect.CedulaMecanico = Convert.ToString(reader["CedulaMecanico"]);
                reparacionesSelect.Matricula = Convert.ToString(reader["Matricula"]);
                reparacionesSelect.IdEstadoReparacion = Convert.ToInt32(reader["IdEstadoReparacion"]);
            }
            reader.Close();

            return reparacionesSelect;

        }

        public IEnumerable<Reparaciones> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
