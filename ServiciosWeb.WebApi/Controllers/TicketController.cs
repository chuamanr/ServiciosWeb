using ServiciosWeb.Datos.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class TicketController : ApiController
    {
        LibreriaConnection BD = new LibreriaConnection();

        [HttpGet]
        public IEnumerable<status_tk> Get()
        {
            var listado = BD.status_tk.ToList();
            return listado;
        }

        [HttpGet]
        public status_tk Get(string id)
        {
            var status_tk = BD.status_tk.FirstOrDefault(x => x.message_id == id);
            return status_tk;
        }

        [HttpPost]
        public void Post([FromBody]object value)
        {
        }

    }
}
