using Newtonsoft.Json;
using ServiciosWeb.Datos.Modelo;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web.Http;
using ServiciosWeb.Datos;

namespace ServiciosWeb.WebApi.Controllers
{
    public class ShippingUpdateController : ApiController
    {
        private LibreriaConnection dbContext = new LibreriaConnection();

        [HttpGet]
        public IEnumerable<RootObject> Get()
        {
            var listado = dbContext.RootObject.ToList();
            return listado;
        }

        [HttpGet]
        public RootObject Get(string id)
        {
            var rootObject = dbContext.RootObject.FirstOrDefault(x => x.message_id == id);
            return rootObject;
        }

        [HttpPost]

        public IHttpActionResult AgregaTicket([FromBody] RootObject root)
        {
            if (ModelState.IsValid)
            {
                dbContext.RootObject.Add(root);
                dbContext.SaveChanges();
                return Ok(root);
            }
            else
            {
                return BadRequest();
            }
        }
        


    }
}
