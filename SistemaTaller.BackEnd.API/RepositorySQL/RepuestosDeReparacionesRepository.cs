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
    public class RepuestosDeReparacionesRepository : ConexionDB, IRepuestosDeReparacionesRepository
    {
        public RepuestosDeReparacionesRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public void Actualizar(RepuestosDeReparaciones t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(RepuestosDeReparaciones repuestosDeReparaciones)
        {
            var query = "SP_RepuestosDeReparaciones_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CodigoRepuesto", repuestosDeReparaciones.CodigoRepuesto);
            command.Parameters.AddWithValue("@NumeroReparacion", repuestosDeReparaciones.NumeroReparacion);
            command.Parameters.AddWithValue("@PrecioRepuesto", repuestosDeReparaciones.PrecioRepuesto);
            command.Parameters.AddWithValue("@CreadoPor", repuestosDeReparaciones.CreadoPor);

            command.ExecuteNonQuery();
        }

        public RepuestosDeReparaciones SeleccionarPorId(string CodigoRepuesto)
        {
            var query = "SELECT * FROM vwRepuestosDeReparacion_SeleccionarTodo WHERE CodigoRepuesto = @CodigoRepuesto";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@CodigoRepuesto", CodigoRepuesto);

            SqlDataReader reader = command.ExecuteReader();
            RepuestosDeReparaciones repuestoSelect = new();

            while (reader.Read())
            {
                repuestoSelect.CodigoRepuesto = Convert.ToString(reader["CodigoRepuesto"]);
                repuestoSelect.NumeroReparacion = Convert.ToInt32(reader["NumeroReparacion"]);
                repuestoSelect.PrecioRepuesto = Convert.ToDecimal(reader["PrecioRepuesto"]);

            }
            reader.Close();
            return repuestoSelect;
        }

        public IEnumerable<RepuestosDeReparaciones> SeleccionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
