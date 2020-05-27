using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWeb.WebApi.Classes
{
    public class WsJooycar
    {


        public class Rootobject
        {
            public string status { get; set; }
            public Message message { get; set; }
        }

        public class Message
        {
            public string id { get; set; }
            public string company { get; set; }
            public string tenant { get; set; }
            public Unit[] units { get; set; }
            public Shippinginfo shippingInfo { get; set; }
        }

        public class Shippinginfo
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
            public string fechaEmision { get; set; }
        }

        public class Unit
        {
            public string imei { get; set; }
            public string serialNumber { get; set; }
            public string stock { get; set; }
            public string model { get; set; }
            public string warehouse { get; set; }
            public string refType { get; set; }
            public string refId { get; set; }
        }

    }
}