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
    
    public partial class TB_Empleados
    {
        public TB_Empleados()
        {
            this.TB_Compras = new HashSet<TB_Compras>();
            this.TB_Usuarios = new HashSet<TB_Usuarios>();
        }
    
        public int Empleado_ID { get; set; }
        public string Empleado_Nombre { get; set; }
        public string Empleado_Apellido { get; set; }
        public int Empleado_Tel { get; set; }
        public string Empleado_Direccion { get; set; }
        public int DeptoID_Empleado { get; set; }
    
        public virtual ICollection<TB_Compras> TB_Compras { get; set; }
        public virtual TB_Departamentos TB_Departamentos { get; set; }
        public virtual ICollection<TB_Usuarios> TB_Usuarios { get; set; }
    }
}
