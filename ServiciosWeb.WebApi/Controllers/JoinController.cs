using ServiciosWeb.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.WebApi.Controllers
{
    public class JoinController : ApiController
    {
        LibreriaConnection DSE = new LibreriaConnection();
        [Route("Api")]

        [HttpGet]
        public object JoinStatement()
        {
            using (DSE)
            {
                var result = (from e in DSE.RootObject
                              join d in DSE.body on e.message_id equals d.id
                              join ws in DSE.units on e.message_id equals ws.message_id
                              join sw in DSE.shippingInfo on e.message_id equals sw.message_id
                              select new
                              {
                                  //status = e.status,
                                  id = e.message_id,
                                  company = d.company,
                                  tenant = d.tenant,
                                  imei = ws.imei,
                                  serialNumber = ws.serialNumber,
                                  stock = ws.stock,
                                  model = ws.model,
                                  warehouse = ws.warehouse,
                                  refType = ws.refType,
                                  refId = ws.refId,
                                  nombres = sw.nombres,
                                  apellidoPaterno = sw.apellidoPaterno,
                                  apellidoMaterno = sw.apellidoMaterno,
                                  rut = sw.rut,
                                  direccion = sw.direccion,
                                  comuna = sw.comuna,
                                  tel = sw.tel,
                                  email = sw.email,
                                  marca = sw.marca,
                                  modelo = sw.modelo,
                                  vin = sw.vin,
                                  patente = sw.patente,
                                  poliza = sw.poliza,
                                  fechaEmision = sw.fechaEmision,

                              }).ToList();
                // TODO utilize the above result

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented);
                return result;
            }
        }
    }

}
