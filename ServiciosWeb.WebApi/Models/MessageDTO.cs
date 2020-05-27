using ServiciosWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Models
{
    public class MessageDTO : ApiController
    {

        public string id { get; set; }
        public string company { get; set; }
        public string tenant { get; set; }

        public virtual units units { get; set; }
        public virtual shippingInfo shippingInfo { get; set; }
        public virtual RootObject status_tk { get; set; }
        
    }
}
