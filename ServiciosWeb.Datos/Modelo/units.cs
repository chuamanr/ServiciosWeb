//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWeb.Datos.Modelo
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class units
    {
        [JsonIgnore]
        public int id { get; set; }

        [JsonIgnore]
        public string message_id { get; set; }
        public string imei { get; set; }
        public string serialNumber { get; set; }
        public string stock { get; set; }
        public string model { get; set; }
        public string warehouse { get; set; }
        public string refType { get; set; }
        public string refId { get; set; }
    
        public virtual body body { get; set; }
    }
}
