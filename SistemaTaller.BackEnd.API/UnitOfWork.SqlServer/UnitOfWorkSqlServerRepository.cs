﻿


using SistemaTaller.BackEnd.API.Repository.Interfaces;
using SistemaTaller.BackEnd.API.Repository;
using SistemaTaller.BackEnd.API.UnitOfWork.Interfaces;
using System.Data.SqlClient;
using SistemaTaller.BackEnd.API.RepositorySQL;

namespace SistemaTaller.BackEnd.API.UnitOfWork.SqlServer
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {

        public IVehiculosRepository VehiculosRepository { get; }

        //Acá van todos los otros repositorios
        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            VehiculosRepository = new VehiculosRepository(context, transaction);
            //Acá van todos los otros repositorios

        }

    }
}