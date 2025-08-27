using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascotas.Modelos;

namespace Tienda_Mascotas.Gestores
{
    public class gestorProductos
    {

        List<Productos> listaProductos = new List<Productos>();

        public void altaProductos(Productos produc)
        {
            if (listaProductos.Any(prod => prod.ID_PRODUCTO == produc.ID_PRODUCTO))
            {
                Console.WriteLine("Este producto ya se encuentra registrado");
                return;
            }
            else
            {
                listaProductos.Add(produc);
            }
        }
        public void mostrarProductos()
        {
            foreach (Productos produc in listaProductos)
            {
                Console.WriteLine($"ID: {produc.ID_PRODUCTO}, Nombre: {produc.NOMBRE_PRODUCTO}, Precio: {produc.PRECIO}, ID:Animal: {produc.ID_ANIMAL}");
                //Console.WriteLine("");
            }
        }
        public void actualizarProducto(Productos produc)
        {
            Productos freshProducto = listaProductos.FirstOrDefault(prod => prod.ID_PRODUCTO == produc.ID_PRODUCTO);
            if (freshProducto != null)
            {
                //freshProducto=produc;//- Ahora freshProducto apunta a otro objeto (produc), pero la lista sigue apuntando al objeto original, que quedó sin cambios.
                freshProducto.ID_PRODUCTO = produc.ID_PRODUCTO;
                freshProducto.NOMBRE_PRODUCTO = produc.NOMBRE_PRODUCTO;
                freshProducto.PRECIO = produc.PRECIO;
                freshProducto.ID_ANIMAL = produc.ID_ANIMAL;

                Console.WriteLine("Se ha actualizado el producto");
            }
            else
            {
                Console.WriteLine("No se ha encontrado un producto con ese ID");
            }
        }
        public void borrarProducto(Productos produc)
        {
            if (listaProductos.Any(prod => prod.ID_PRODUCTO == produc.ID_PRODUCTO))
            {
                listaProductos.Remove(produc);
            }
            else
            {
                Console.WriteLine("No se encontró un producto con ese ID");
            }
        }

    }
}
