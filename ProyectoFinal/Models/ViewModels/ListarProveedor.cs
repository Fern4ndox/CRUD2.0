using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models.ViewModels
{
    public class ListarProveedor
    {
        public int ProveedorID{ get; set; }
        public string Proveedor_Nombre { get; set; }
        public string Proveedor_Direccion { get; set; }
        public int Proveedor_Tel{ get; set; }
        public string Proveedor_Email { get; set; }
    }
}