//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo001_Rest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CLIENTE
    {
      
        public decimal CL_IDENTIFICACION { get; set; }
        public string CL_NOMBRES { get; set; }
        public decimal CL_TELEFONO { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime CL_FECHA_NAC { get; set; }
        public string CL_GENERO { get; set; }
        public string CL_DIRECCION { get; set; }
    
    }
}
