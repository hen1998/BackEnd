using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo001_Rest
{
    public partial class ENCABEZADO_FACT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENCABEZADO_FACT()
        {
            this.CUERPO_FACTURA = new List<CUERPO_FACTURA>();
        }

        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<CUERPO_FACTURA> CUERPO_FACTURA { get; set; }
    }
}