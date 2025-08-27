using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Modelos
{
    public class Empleados
    {
        private string idEmpleado;
        private string nombreEmpleado;
        //public Empleados(string idempleado)

        public string ID_EMPLEADO
        {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value; }
        }
        public string NOMBRE_EMPLEADO
        {
            get { return this.nombreEmpleado; }
            set { this.nombreEmpleado = value; }
        }
    }
}
