using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private static int comision = 12;

        public static int Comision
        {
            get { return comision; }
            set { comision = value; }
        }

        public Empleado(string pId, string pNombre, string pApellido)
        {
            Id = pId;
            Nombre = pNombre;
            Apellido = pApellido;

        }
    }

    

}
