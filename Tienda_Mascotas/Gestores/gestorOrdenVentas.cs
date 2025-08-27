using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascotas.Modelos;

namespace Tienda_Mascotas.Gestores
{
    public class gestorOrdenVentas
    {
        List<ordenVenta> listaOrdenVentas = new List<ordenVenta>();

        public void altaOrden(ordenVenta nuevaOrden)
        {
            ordenVenta refOrden = listaOrdenVentas.FirstOrDefault(ord => (ord.IDVENTA == ord.IDRODUCTO) && (ord.IDVENTA == ord.IDRODUCTO));
            if (refOrden != null)
            {
                Console.WriteLine("La orden de venta ya ha sido registrada");
            }
            else
            {
                listaOrdenVentas.Add(nuevaOrden);

            }
        }
        public void mostrarOrden()
        {
            foreach (ordenVenta orden in listaOrdenVentas)
            {
                Console.WriteLine($"ID_Venta: {orden.IDVENTA}, ID_Producto{orden.IDRODUCTO}, Cantidad: {orden.CANTIDADPRODUCTO} ");
            }
        }

        public void actualizarOrden(ordenVenta updaOrden)
        {
            ordenVenta refOrden = listaOrdenVentas.FirstOrDefault(refOr => (refOr.IDVENTA == updaOrden.IDVENTA) && (refOr.IDRODUCTO == updaOrden.IDRODUCTO));
            if (refOrden != null)
            {
                refOrden.CANTIDADPRODUCTO = updaOrden.CANTIDADPRODUCTO;
            }
            else
            {
                Console.WriteLine("No se encontró una orden con los ID de productos y Ventas señalados");
            }
        }
        public void borrarOrden(ordenVenta borrarOrden)
        {
            ordenVenta referenciaOrden = listaOrdenVentas.FirstOrDefault(refeOr => (refeOr.IDVENTA == borrarOrden.IDVENTA) && (refeOr.IDRODUCTO == borrarOrden.IDRODUCTO));

            if (referenciaOrden != null)
            {
                listaOrdenVentas.Remove(referenciaOrden);
            }
            else
            {
                Console.WriteLine("No se encontró una orden con los ID de producto y venta especificados");
            }
        }

    }
}
