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
            ordenVenta refOrden = listaOrdenVentas.FirstOrDefault(ord => (ord.IDVENTA == nuevaOrden.IDVENTA) && (ord.IDPRODUCTO == nuevaOrden.IDPRODUCTO));
            if (refOrden != null)
            {
                throw new InvalidOperationException($"La orden de venta con el ID de venta {refOrden.IDVENTA} e ID de producto {refOrden.IDPRODUCTO} ya se registraron");
                //Console.WriteLine("La orden de venta ya ha sido registrada");
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
                Console.WriteLine($"ID_Venta: {orden.IDVENTA}, ID_Producto{orden.IDPRODUCTO}, Cantidad: {orden.CANTIDADPRODUCTO} ");
            }
        }

        public void actualizarOrden(ordenVenta updaOrden)
        {
            ordenVenta refOrden = listaOrdenVentas.FirstOrDefault(refOr => (refOr.IDVENTA == updaOrden.IDVENTA) && (refOr.IDPRODUCTO == updaOrden.IDPRODUCTO));
            if (refOrden != null)
            {
                refOrden.CANTIDADPRODUCTO = updaOrden.CANTIDADPRODUCTO;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró una orden con el ID de producto: {updaOrden.IDPRODUCTO} e ID de venta:  {updaOrden.IDVENTA}");
                //Console.WriteLine("No se encontró una orden con los ID de productos y Ventas señalados");
            }
        }
        public void borrarOrden(ordenVenta borrarOrden)
        {
            ordenVenta referenciaOrden = listaOrdenVentas.FirstOrDefault(refeOr => (refeOr.IDVENTA == borrarOrden.IDVENTA) && (refeOr.IDPRODUCTO == borrarOrden.IDPRODUCTO));

            if (referenciaOrden != null)
            {
                listaOrdenVentas.Remove(referenciaOrden);
            }
            else
            {
                throw new KeyNotFoundException("No se encontró una orden con los ID de producto y venta especificados");
                //Console.WriteLine("No se encontró una orden con los ID de producto y venta especificados");
            }
        }

    }
}
