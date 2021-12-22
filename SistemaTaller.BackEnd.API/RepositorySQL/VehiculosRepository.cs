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
    public class VehiculosRepository : ConexionDB, IVehiculosRepository
    {
        public VehiculosRepository(SqlConnection context, SqlTransaction transaction)
        {
            this._context = context;
            this._transaction = transaction;
        }
        public void Actualizar(Vehiculos vehiculos)
        {
            var query = "UPDATE Vehiculos SET Matricula = @Matricula, MarcaVehiculo = @MarcaVehiculo, Modelo = @Modelo, ModificadoPor = @ModificadoPor, FechaModificacion = @FechaModificacion WHERE Matricula = @Matricula";
            var comand = CreateCommand(query);

            comand.Parameters.AddWithValue("@Matricula", vehiculos.Matricula);
            comand.Parameters.AddWithValue("@MarcaVehiculo", vehiculos.MarcaVehiculo);
            comand.Parameters.AddWithValue("@Modelo", vehiculos.Modelo);
            comand.Parameters.AddWithValue("@ModificadoPor", vehiculos.ModificadoPor);
            comand.Parameters.AddWithValue("@FechaModificacion", vehiculos.FechaModificacion);

            comand.ExecuteNonQuery();

        }

        public void Elimnar()
        {
            throw new NotImplementedException();
        }


        public void Insertar(Vehiculos vehiculos)
        {
            var query = "SP_Vehiculos_Insert";
            var command = CreateCommand(query);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Matricula", vehiculos.Matricula);
            command.Parameters.AddWithValue("@MarcaVehiculo", vehiculos.MarcaVehiculo);
            command.Parameters.AddWithValue("@Modelo", vehiculos.Modelo);
            command.Parameters.AddWithValue("@CreadoPor", vehiculos.CreadoPor);

            command.ExecuteNonQuery();
        }

        public Vehiculos SeleccionarPorId(string Matricula)
        {
            var query = "SELECT * FROM vwVehiculos_SeleccionarTodo WHERE Matricula = @Matricula";
            var command = CreateCommand(query);

            command.Parameters.AddWithValue("@Matricula", Matricula);

            SqlDataReader reader = command.ExecuteReader();

            Vehiculos vehiculosSelect = new();

            while (reader.Read())
            {
                vehiculosSelect.Matricula = Convert.ToString(reader["Matricula"]);
                vehiculosSelect.MarcaVehiculo = Convert.ToString(reader["MarcaVehiculo"]);
                vehiculosSelect.Modelo = Convert.ToString(reader["Modelo"]);
            
            }
            reader.Close();

            return vehiculosSelect;
        }

        public List<Vehiculos> SeleccionarTodos()
        {
            var query = "SELECT * FROM vwVehiculos_SeleccionarTodo";
            var command = CreateCommand(query);

            SqlDataReader reader = command.ExecuteReader();

            List<Vehiculos> listVehiculos = new List<Vehiculos>();

            while (reader.Read())
            {
                Vehiculos vehiculosSelect = new();

                vehiculosSelect.Matricula = Convert.ToString(reader["Matricula"]);
                vehiculosSelect.MarcaVehiculo = Convert.ToString(reader["MarcaVehiculo"]);
                vehiculosSelect.Modelo = Convert.ToString(reader["Modelo"]);
                vehiculosSelect.Activo = Convert.ToBoolean(reader["Activo"]);
                vehiculosSelect.FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]);
                vehiculosSelect.FechaModificacion = (DateTime?)(reader.IsDBNull("FechaModificacion") ? null : reader["FechaModificacion"]);
                vehiculosSelect.CreadoPor = Convert.ToString(reader["CreadoPor"]);
                vehiculosSelect.ModificadoPor = Convert.ToString(reader["ModificadoPor"]);

                listVehiculos.Add(vehiculosSelect);

            }

            reader.Close();
            return listVehiculos;
        }
    }
}
