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
    public class RepuestosRepository : ConexionDB, IRepuestosRepository
    {
        public RepuestosRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }

        public void Actualizar(Repuestos t)
        {
            throw new NotImplementedException();
        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }

        public void Insertar(Repuestos repuestos)
        {
            var query = "SP_Repuestos_Insert";
            var command = CreateCommand(query);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CodigoRepuesto", repuestos.CodigoRepuesto);
            command.Parameters.AddWithValue("@Marca", repuestos.Marca);
            command.Parameters.AddWithValue("@Tipo", repuestos.Tipo);
            command.Parameters.AddWithValue("@FechaCompra", repuestos.FechaCompra);
            command.Parameters.AddWithValue("@Precio", repuestos.Precio);
            command.Parameters.AddWithValue("@CreadoPor", repuestos.CreadoPor);

            command.ExecuteNonQuery();


        }

        public Repuestos SeleccionarPorId(string CodigoRepuesto)
        {
            var query = "SELECT * FROM vwRepuestos_SeleccionarTodo WHERE CodigoRepuesto = @CodigoRepuesto";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@CodigoRepuesto", CodigoRepuesto);

            SqlDataReader reader = command.ExecuteReader();
            Repuestos repuestosSelect = new();

            while (reader.Read())
            {
                repuestosSelect.CodigoRepuesto = Convert.ToString(reader["CodigoRepuesto"]);
                repuestosSelect.Marca = Convert.ToString(reader["Marca"]);
                repuestosSelect.Tipo = Convert.ToString(reader["Tipo"]);
                repuestosSelect.FechaCompra = Convert.ToDateTime(reader["FechaCompra"]);
                repuestosSelect.Precio = Convert.ToDecimal(reader["Precio"]);
                
            }
            reader.Close();
            return repuestosSelect;
        }

        public List<Repuestos> SeleccionarTodos()
        {
            var query = "SELECT * FROM vwRepuestosDeReparacion_SeleccionarTodo";
            var command = CreateCommand(query);

            SqlDataReader reader = command.ExecuteReader();

            List<Repuestos> lisRespuestos = new List<Repuestos>();

            while (reader.Read())
            {
                Repuestos repuestosSelect = new();

                repuestosSelect.CodigoRepuesto = Convert.ToString(reader["CodigoRepuesto"]);
                repuestosSelect.Marca = Convert.ToString(reader["Marca"]);
                repuestosSelect.Tipo = Convert.ToString(reader["Tipo"]);
                repuestosSelect.FechaCompra = Convert.ToDateTime(reader["FechaCompra"]);
                repuestosSelect.Precio = Convert.ToDecimal(reader["Precio"]);
                repuestosSelect.Activo = Convert.ToBoolean(reader["Activo"]);
                repuestosSelect.FechaCompra = Convert.ToDateTime(reader["FechaCreacion"]);
                repuestosSelect.FechaModificacion = (DateTime?)(reader.IsDBNull("FechaModificacion") ? null : reader["FechaModificacion"]);
                repuestosSelect.CreadoPor = Convert.ToString(reader["CreadoPor"]);
                repuestosSelect.ModificadoPor = Convert.ToString(reader["ModificadoPor"]);

                lisRespuestos.Add(repuestosSelect);
            }
            reader.Close();
            return lisRespuestos;
        }
    }
}
