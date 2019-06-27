using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServiceWCF.ConnectionDataBase
{
    public static class Connection
    {

        #region Properties
        private static string _connectionString = ConfigurationManager.ConnectionStrings["DBAgenda"].ConnectionString;
        private static SqlConnection _sqlConnection { get; set; }
        #endregion

        #region Public Methods
        public static SqlConnection GetConnection()
        {
            if (_sqlConnection == null)
            {
                _sqlConnection = new SqlConnection(_connectionString);
                return _sqlConnection;
            }
            else
            {
                return _sqlConnection;
            }
        }
        #endregion
    }
}