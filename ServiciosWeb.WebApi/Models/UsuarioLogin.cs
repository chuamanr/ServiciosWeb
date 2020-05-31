using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWeb.WebApi.Models
{
    public class UsuarioLogin
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}