using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models.ViewModels
{
    public class ListarUsuarios
    {
        public int UsuarioID { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Usuario_Pass{ get; set; }
        public int EmpleadoUsuario_ID{ get; set; }
        public string EmpleadoUsuario_Nombre { get; set; }
    }
}