//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Ventas
    {
        public int Venta_ID { get; set; }
        public int Venta_NoFact { get; set; }
        public int ClienteID_Venta { get; set; }
        public int Venta_NIT { get; set; }
        public int Venta_Precio { get; set; }
        public int CarroID_Venta { get; set; }
    
        public virtual TB_Carros TB_Carros { get; set; }
        public virtual TB_Clientes TB_Clientes { get; set; }
    }
}
