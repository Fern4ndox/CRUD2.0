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
    
    public partial class TB_Usuarios
    {
        public int Usuario_ID { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Pass { get; set; }
        public int EmpleadoID_Usuario { get; set; }
    
        public virtual TB_Empleados TB_Empleados { get; set; }
    }
}