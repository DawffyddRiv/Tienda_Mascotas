using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Modelos
{
    public class ordenVenta
    {
        private string idVenta;
        private string idProducto;
        private int cantidadProducto;

        public string IDVENTA
        {
            get { return this.idVenta; }
            set { this.idVenta = value; }
        }
        public string IDPRODUCTO
        {
            get { return this.idProducto; }
            set { this.idProducto = value; }
        }

        public int CANTIDADPRODUCTO
        {
            get { return this.cantidadProducto; }
            set { this.cantidadProducto = value; }
        }
    }
}
