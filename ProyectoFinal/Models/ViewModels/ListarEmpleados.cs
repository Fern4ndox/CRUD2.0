using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models.ViewModels
{
    public class ListarEmpleados
    {
        public int EmpleadoID { get; set; }
        public string Empleado_Nombre { get; set; }
        public string Empleado_Apellido{ get; set; }
        public string Empleado_Direccion { get; set; }
        public int Empleado_Tel { get; set; }
        public int DeptoEmpleado_ID { get; set; }
    }
}