using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebServiceWCF.ConnectionDataBase;
using WebServiceWCF.Models;

namespace WebServiceWCF.Repositories
{
    public class ZonasRepository
    {
        #region Properties
        public SqlConnection sqlConnection { get; set; }
        #endregion

        #region Public Methods
        public List<Zonas> GetZonas()
        {
            List<Zonas> zonas = new List<Zonas>();
            try
            {
                sqlConnection = Connection.GetConnection();
                SqlCommand sqlCommand = new SqlCommand
                {
                    Connection = sqlConnection,
                    CommandText = "select Id, Zona from dbo.ZonasDireccion ",
                };
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    zonas.Add(new Zonas
                    {
                        Id = int.Parse(dataReader["Id"].ToString()),
                        Zona = dataReader["Zona"].ToString()
                    });
                }
                sqlConnection.Close();
            }
            catch (SqlException)
            {
            }
            catch (Exception)
            {
                throw;
            }
            return zonas;
        }
        #endregion
    }
}