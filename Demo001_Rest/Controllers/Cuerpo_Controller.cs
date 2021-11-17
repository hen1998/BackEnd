using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo001_Rest.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")] // Aplica a todo el controlador
    public class Cuerpo_Controller : ApiController
    {
        FACTURACION_MYMEntities Contexto;

        public Cuerpo_Controller()
        {
            Contexto = new FACTURACION_MYMEntities();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }

        [NonAction]
        private CUERPO_FACTURA SeleccionPorId(int cod)
        {
            return Contexto.CUERPO_FACTURA.Where(E => E.CUE_COD == cod).SingleOrDefault();
        }

        // GET: api/Cuerpo_
        public IHttpActionResult Get()
        {
            List<CUERPO_FACTURA> cuerpo = Contexto.CUERPO_FACTURA.ToList();
            if (cuerpo == null)
            {
                return NotFound();
            }
            else
            {
                return Ok( cuerpo);
            }
        }

        // GET: api/Cuerpo_/5
        public CUERPO_FACTURA Get(int id)
        {
            return Contexto.CUERPO_FACTURA.Where(p => p.CUE_COD == id).SingleOrDefault();
        }

        // POST: api/Cuerpo_
        public bool Post(CUERPO_FACTURA cuerpo)
        {
            Contexto.CUERPO_FACTURA.Add(cuerpo);
            Contexto.SaveChanges();
            return true;
        }

        // PUT: api/Cuerpo_/5
        public bool Put(int id, CUERPO_FACTURA cuerpo)
        {
            CUERPO_FACTURA cuerpoTemp = SeleccionPorId(cuerpo.CUE_COD);
            if (cuerpoTemp != null)
            {
                cuerpoTemp.ENC_CODIGO = cuerpo.ENC_CODIGO;
                cuerpoTemp.PRO_COD = cuerpo.PRO_COD;
                cuerpoTemp.CUE_CANTIDAD = cuerpo.CUE_CANTIDAD;
                cuerpoTemp.CUE_VALORTOTAL = cuerpo.CUE_VALORTOTAL;
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Cuerpo_/5
        public bool Delete(int id)
        {
            CUERPO_FACTURA cuerpoTemp = SeleccionPorId(id);
            if (cuerpoTemp != null)
            {
                Contexto.CUERPO_FACTURA.Remove(cuerpoTemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
