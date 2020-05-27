using ServiciosWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Models
{
    public class ShippingInfoDTO : ApiController
    {
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string rut { get; set; }
        public string direccion { get; set; }
        public string comuna { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string vin { get; set; }
        public string patente { get; set; }
        public string poliza { get; set; }
        public Nullable<System.DateTime> fechaEmision { get; set; }

        public virtual body body { get; set; }
    }
}
