using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoDAS.Models
{
    public class Usuario
    {
        public int IDusuario { get; set; }
        public string Correo {  get; set; }
        public string Clave { get; set; }
        public string Rol {  get; set; }

        public string confirmarClave { get; set; }
    }
}