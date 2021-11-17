using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Demo001_Rest
{
    public partial class CLIENTE
    {

        #region Propiedades de navegacion
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual List<ENCABEZADO_FACT> ENCABEZADO_FACT { get; set; }
        #endregion
    }
}