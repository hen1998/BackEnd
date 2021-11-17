using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo001_Rest
{
    public partial class CUERPO_FACTURA
    {
        public virtual ENCABEZADO_FACT ENCABEZADO_FACT { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}