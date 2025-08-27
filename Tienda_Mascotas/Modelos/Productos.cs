using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Modelos
{
    public class Productos
    {

        private string idProducto;
        private string nombreProducto;
        private double precio;
        private string id_Animal;

        public string ID_PRODUCTO
        {
            set { this.idProducto = value; }
            get { return this.idProducto; }
        }
        public string NOMBRE_PRODUCTO
        {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value; }
        }
        public double PRECIO
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public string ID_ANIMAL
        {
            get { return this.id_Animal; }
            set { this.id_Animal = value; }
        }
    }
}
