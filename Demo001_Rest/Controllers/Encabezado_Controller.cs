using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo001_Rest.Controllers
{
    [EnableCors(origins: "https://localhost:44329", headers: "*", methods: "*")] // Aplica a todo el controlador
    public class Encabezado_Controller : ApiController
    {

        FACTURACION_MYMEntities Context;

        public Encabezado_Controller()
        {
            Context = new FACTURACION_MYMEntities();
            Context.Configuration.ProxyCreationEnabled = false;
        }

        [NonAction]
        private ENCABEZADO_FACT SeleccionPorId(int cod)
        {
            return Context.ENCABEZADO_FACT.Where(ENCABEZADO_FACT => ENCABEZADO_FACT.ENC_CODIGO == cod).SingleOrDefault();
        }

        // GET: api/Encabezado_
        public IHttpActionResult Get()
        {
            List<ENCABEZADO_FACT> encabezado = Context.ENCABEZADO_FACT.ToList();
            if (encabezado == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(encabezado);
            }
        }

        // GET: api/Encabezado_/5
        public  ENCABEZADO_FACT Get(int id)
        {
            return Context.ENCABEZADO_FACT.Where(p => p.ENC_CODIGO == id).SingleOrDefault();
        }

        // POST: api/Encabezado_
        public bool Post(ENCABEZADO_FACT nuevoEncabezado)
        {
            Context.ENCABEZADO_FACT.Add(nuevoEncabezado);
            Context.SaveChanges();
            return true;
        }

        // PUT: api/Encabezado_/5
        public bool Put(int id, ENCABEZADO_FACT Encabezado)
        {
            ENCABEZADO_FACT EncabezadoTemp = SeleccionPorId(Encabezado.ENC_CODIGO);
            if (EncabezadoTemp != null)
            {
                EncabezadoTemp.CL_IDENTIFICACION = Encabezado.CL_IDENTIFICACION;
                EncabezadoTemp.ENC_AUTORIZACION = Encabezado.ENC_AUTORIZACION;
                EncabezadoTemp.ENC_CIUDAD = Encabezado.ENC_CIUDAD;
                EncabezadoTemp.ENC_FORMAPAGO = Encabezado.ENC_FORMAPAGO;
                Context.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Encabezado_/5
        public bool Delete(int id)
        {
            ENCABEZADO_FACT EncabezadoTemp = SeleccionPorId(id);
            if (EncabezadoTemp != null)
            {
                Context.ENCABEZADO_FACT.Remove(EncabezadoTemp);
                Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
