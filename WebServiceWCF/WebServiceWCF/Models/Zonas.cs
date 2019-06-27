using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceWCF.Models
{
    [DataContract]
    public class Zonas
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Zona { get; set; }
    }
}