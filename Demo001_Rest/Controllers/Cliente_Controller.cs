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
    public class Cliente_Controller : ApiController
    {

        FACTURACION_MYMEntities Context;

        public Cliente_Controller()
        {
            Context = new FACTURACION_MYMEntities();
            Context.Configuration.ProxyCreationEnabled = false;
        }

        [NonAction]
        private CLIENTE SeleccionPorId(decimal cod)
        {
            return Context.CLIENTE.Where(CLIENTE => CLIENTE.CL_IDENTIFICACION == cod).SingleOrDefault();
        }

        // GET: api/Cliente_
        public List<CLIENTE> Get()
        {
            return Context.CLIENTE.ToList();
        }

        // GET: api/Cliente_/5
        public CLIENTE Get(decimal id)
        {
            return Context.CLIENTE.Where(CLIENTE => CLIENTE.CL_IDENTIFICACION == id).SingleOrDefault();
        }

        // POST: api/Cliente_
        public bool Post(CLIENTE post_Cliente)
        {
            Context.CLIENTE.Add(post_Cliente);
            Context.SaveChanges();
            return true;
        }

        // PUT: api/Cliente_/5
        public bool Put(decimal id, CLIENTE put_Cliente)
        {

            CLIENTE clienteTemp = SeleccionPorId(id);
            if (clienteTemp != null)
            {
                clienteTemp.CL_NOMBRES = put_Cliente.CL_NOMBRES;
                clienteTemp.CL_TELEFONO = put_Cliente.CL_TELEFONO;
                clienteTemp.CL_GENERO = put_Cliente.CL_GENERO;
                clienteTemp.CL_FECHA_NAC = put_Cliente.CL_FECHA_NAC;
                clienteTemp.CL_DIRECCION = put_Cliente.CL_DIRECCION;
                Context.SaveChanges();
                return true;
            }
            return false;

        }

        // DELETE: api/Cliente_/5
        public bool Delete(decimal id)
        {
            CLIENTE clienteTemp = SeleccionPorId(id);
            if (clienteTemp != null)
            {
                Context.CLIENTE.Remove(clienteTemp);
                Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
