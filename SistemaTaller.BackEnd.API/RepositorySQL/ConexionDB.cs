using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTaller.BackEnd.API.RepositorySQL
{
    
    
        public abstract class ConexionDB
        {
            protected SqlConnection _context;
            protected SqlTransaction _transaction;

            protected SqlCommand CreateCommand   (string query)
            {
                return new SqlCommand(query, _context, _transaction);
            }

        }
    
}
