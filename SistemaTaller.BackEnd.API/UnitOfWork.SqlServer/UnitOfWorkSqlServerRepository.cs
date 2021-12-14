using SistemaTaller.BackEnd.API.Repository;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System.Data.SqlClient;
using SistemaTaller.BackEnd.API.RepositorySQL;

namespace SistemaTaller.BackEnd.API.UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {

        public IVehiculosRepository VehiculosRepository { get; }
        public IClientesRepository ClientesRepository { get; }
        public IMecanicosRepository MecanicosRepository { get; }
        public ITalleresRepository TalleresRepository { get; }
        public IMecanicosDeTalleresRepository MecanicosDeTalleresRepository { get; }

        public IVehiculosDeClientesRepository VehiculosDeClientesRepository { get; }
        public IRepuestosRepository RepuestosRepository { get; }
        public IEstadoReparacionesRepository EstadoReparacionesRepository { get; }
        public IReparacionesRepository ReparacionesRepository { get; }
        public IRepuestosDeReparacionesRepository RepuestosDeReparacionesRepository { get; }



        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            VehiculosRepository = new VehiculosRepository(context, transaction);
            ClientesRepository = new ClientesRepository(context, transaction);
            MecanicosRepository = new MecanicosRepository(context, transaction);
            TalleresRepository = new TalleresRepository(context, transaction);
            MecanicosDeTalleresRepository = new MecanicosDeTalleresRepository(context, transaction);
            VehiculosDeClientesRepository = new VehiculosDeClientesRepository(context, transaction);
            RepuestosRepository = new RepuestosRepository(context, transaction);
            EstadoReparacionesRepository = new EstadoReparacionesRepository(context, transaction);
            ReparacionesRepository = new ReparacionesRepository(context, transaction);
            RepuestosDeReparacionesRepository = new RepuestosDeReparacionesRepository(context, transaction);
            

        }

    }
}
