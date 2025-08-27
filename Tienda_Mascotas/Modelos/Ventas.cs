using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Modelos
{
    public class Ventas
    {
        private string idVentas;
        private string idVendedor;
        private string fechaVenta;

        public string IDVENTA
        {
            get { return this.idVentas; }
            set { this.idVentas = value; }
        }
        public string FECHAVENTA
        {
            get { return this.fechaVenta; }
            set { this.fechaVenta = value; }
        }
        public string ID_EMPLEADO
        {
            get { return this.idVendedor; }
            set { this.idVendedor = value; }
        }
    }
}
