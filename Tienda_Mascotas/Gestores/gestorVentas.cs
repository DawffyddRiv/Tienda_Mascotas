using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tienda_Mascotas.Modelos;

namespace Tienda_Mascotas.Gestores
{
    public class gestorVentas
    {
        List<Ventas> listaVentas = new List<Ventas>();

        public void altaVenta(Ventas venta)
        {
            if (listaVentas.Any(vent => vent.IDVENTA == venta.IDVENTA))
            {
                throw new InvalidOperationException($"El producto con el ID {venta.IDVENTA} ya se encuentra registrado");
                //Console.WriteLine("El producto ya ha sido registrado");

            }
            else
            {
                listaVentas.Add(venta);
            }
        }
        public void mostrarVentas()
        {
            foreach (Ventas venta in listaVentas)
            {
                Console.WriteLine($"ID_Venta {venta.IDVENTA}, Fecha venta: {venta.FECHAVENTA}, ID_Vendedor: {venta.ID_EMPLEADO}");
            }
        }

        public void actualizarVenta(Ventas freshVenta)
        {
            Ventas refVenta = listaVentas.FirstOrDefault(vent => vent.IDVENTA == freshVenta.IDVENTA);
            if (refVenta != null)
            {
                refVenta.IDVENTA = freshVenta.IDVENTA;
                refVenta.FECHAVENTA = freshVenta.FECHAVENTA;
                refVenta.ID_EMPLEADO = freshVenta.ID_EMPLEADO;
            }
            else
            {
                throw new KeyNotFoundException($"No se encontró una venta con el ID {freshVenta.IDVENTA} ");
                //Console.WriteLine("No se ha encontrado una venta con el ID ");
            }
        }
        public void borrarVenta(Ventas eraseVenta)
        {
            Ventas referenciaVenta = listaVentas.FirstOrDefault(vent => vent.IDVENTA == eraseVenta.IDVENTA);

            if (referenciaVenta != null) //Por qué no funciona con firstorDefault? Si funciona, sólo que any regresaba un booleano y firstordefault te regresa el objeto o null
            {
                listaVentas.Remove(referenciaVenta);

            }
            else
            {
                throw new KeyNotFoundException($"No se ha encontrado una venta con el ID: {eraseVenta.IDVENTA} ");
                //Console.WriteLine("No se ha encontrado una venta con ese ID");
            }
        }
    }
}
