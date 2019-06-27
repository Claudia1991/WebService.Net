using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceWCF.Models;
using WebServiceWCF.Repositories;

namespace WebServiceWCF
{
    public class WebServiceWCF : IWebServiceWCF
    {
        #region Properties
        private ZonasRepository zonasRepository;
        #endregion

        #region Public Methods
        public List<Zonas> GetAll()
        {
            List<Zonas> zonas = null;
            zonasRepository = new ZonasRepository();
            try
            {
                zonas = zonasRepository.GetZonas();
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
