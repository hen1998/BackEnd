using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Demo001_Rest.Controllers
{
    [EnableCors(origins: "*", headers:"*",methods:"*")] // Aplica a todo el controlador
    public class Productos_Controller : ApiController
    {

        FACTURACION_MYMEntities Contexto;

        public Productos_Controller()
        {
            Contexto = new FACTURACION_MYMEntities();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }

        [NonAction]
        private PRODUCTO SeleccionPorId(int cod)
        {
            return Contexto.PRODUCTO.Where(PRODUCTO => PRODUCTO.PRO_COD == cod).SingleOrDefault();
        }

        // GET: api/kProductos_
        /* public IHttpActionResult Get()
         {
             List<PRODUCTO> product = Contexto.PRODUCTO.ToList();
             if (product == null)
             {
                 return NotFound();
             }
             else
             {
                 return Ok(product);
             }
         }*/
        public List<PRODUCTO> Get()
        {
            return Contexto.PRODUCTO.ToList();
        }

        //[DisableCors]

        // GET: api/Productos_/5
        public PRODUCTO Get(int id)
        {
            return Contexto.PRODUCTO.Where(p => p.PRO_COD == id).SingleOrDefault();
        }

        // POST: api/Productos_
        public bool Post(PRODUCTO post_producto)
        {
            Contexto.PRODUCTO.Add(post_producto);
            Contexto.SaveChanges();
            return true;
        }

        // PUT: api/Productos_/5
        public bool Put(int id, PRODUCTO put_Producto)
        {
            PRODUCTO PRODUCTOTemp = SeleccionPorId(id);
            if (PRODUCTOTemp != null)
            {
                
                PRODUCTOTemp.PRO_NOMBRE = put_Producto.PRO_NOMBRE;
                PRODUCTOTemp.PRO_SERIE = put_Producto.PRO_SERIE;
                PRODUCTOTemp.PRO_COSTO = put_Producto.PRO_COSTO;
                PRODUCTOTemp.PRO_PVP = put_Producto.PRO_PVP;
                PRODUCTOTemp.PRO_IMAGEN = put_Producto.PRO_IMAGEN;

                Contexto.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE: api/Productos_/5
        public bool Delete(int id)
        {
            PRODUCTO productoTemp = SeleccionPorId(id);
            if (productoTemp != null)
            {
                Contexto.PRODUCTO.Remove(productoTemp);
                Contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
