using System.Diagnostics.Metrics;
using System.Numerics;
using Tienda_Mascotas;
using Tienda_Mascotas.Modelos;
using Tienda_Mascotas.Gestores;

namespace Tienda_Mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gestorAnimales animalGestor = new gestorAnimales();
            Animales miAnimal = new Animales();
            miAnimal.IDANIMAL = "A-01";
            miAnimal.NOMBRE_ANIMAL = "Pancho";
            animalGestor.AltaAnimales(miAnimal);
            animalGestor.MostrarAnimales();
            Console.WriteLine("");
            Animales otroAnimal = new Animales();
            otroAnimal.IDANIMAL = "A-01";
            otroAnimal.NOMBRE_ANIMAL = "Francisco";
            animalGestor.ActualizarAnimales(otroAnimal);
            animalGestor.MostrarAnimales();
            //Agrego otro animal
            Animales animal3 = new Animales();
            animal3.IDANIMAL = "A-02";
            animal3.NOMBRE_ANIMAL = "Fido";
            animalGestor.AltaAnimales(animal3);
            Console.WriteLine("");
            animalGestor.MostrarAnimales();
            animalGestor.borrarAnimal(animal3);
            Console.WriteLine("");
            animalGestor.MostrarAnimales();

            gestorEmpleados gestorStaff = new gestorEmpleados();
            Empleados miEmpleado1 = new Empleados();
            miEmpleado1.ID_EMPLEADO = "E-01";
            miEmpleado1.NOMBRE_EMPLEADO = "Jaime";
            Empleados miEmpleado2 = new Empleados();
            miEmpleado2.ID_EMPLEADO = "E-02";
            miEmpleado2.NOMBRE_EMPLEADO = "Josefina";
            Empleados miEmpleado3 = new Empleados();
            miEmpleado3.ID_EMPLEADO = "E-03";
            miEmpleado3.NOMBRE_EMPLEADO = "Ramiro";
            gestorStaff.altaEmpleados(miEmpleado1);
            gestorStaff.altaEmpleados(miEmpleado2);
            gestorStaff.altaEmpleados(miEmpleado3);
            gestorStaff.mostrarEmpleados();
            Console.WriteLine("\nEjercicio de actualización.");

            Empleados sustituto = new Empleados();
            sustituto.ID_EMPLEADO = "E-01";
            sustituto.NOMBRE_EMPLEADO = "Luisa";
            gestorStaff.actualizaEmpleado(sustituto);
            gestorStaff.mostrarEmpleados();
            Console.WriteLine("Borrando registros");
            gestorStaff.borraEmpleado(miEmpleado2);
            gestorStaff.mostrarEmpleados();

            Console.WriteLine("Lista de productos");

            Productos producto1 = new Productos();
            producto1.ID_PRODUCTO = "P-01";
            producto1.NOMBRE_PRODUCTO = "Arena Gato";
            producto1.PRECIO = 750;
            producto1.ID_ANIMAL = "A-01";

            Productos producto2 = new Productos();
            producto2.ID_PRODUCTO = "P-02";
            producto2.NOMBRE_PRODUCTO = "Croquetas Perro";
            producto2.PRECIO = 420;
            producto2.ID_ANIMAL = "A-02";

            Productos producto3 = new Productos();
            producto3.ID_PRODUCTO = "P-03";
            producto3.NOMBRE_PRODUCTO = "";
            producto3.NOMBRE_PRODUCTO = "Comida Pez";
            producto3.PRECIO = 180;
            producto3.ID_ANIMAL = "A-03";

            gestorProductos misProductos= new gestorProductos();
            misProductos.altaProductos(producto1);
            misProductos.altaProductos(producto2);
            misProductos.altaProductos(producto3);
            misProductos.mostrarProductos();

            Productos nuevoProducto= new Productos();
            nuevoProducto.ID_PRODUCTO = "P-02";
            nuevoProducto.NOMBRE_PRODUCTO = "Arenero";
            nuevoProducto.PRECIO = 950;
            nuevoProducto.ID_ANIMAL = "A-02";
            misProductos.actualizarProducto(nuevoProducto);
            misProductos.mostrarProductos();

            Ventas miVenta1 = new Ventas();
            miVenta1.IDVENTA = "V-01";
            miVenta1.FECHAVENTA = "08/05/2023";
            miVenta1.ID_EMPLEADO = "E-02";

            Ventas miVenta2 = new Ventas();
            miVenta2.IDVENTA = "V-02";
            miVenta2.FECHAVENTA = "10/06/2023";
            miVenta2.ID_EMPLEADO = "E-01";

            Ventas miVenta3=new Ventas();
            miVenta3.IDVENTA = "V-03";
            miVenta3.FECHAVENTA = "15/05/2023";
            miVenta3.ID_EMPLEADO = "E-02";

            gestorVentas misVentas = new gestorVentas();
            misVentas.altaVenta(miVenta1);
            misVentas.altaVenta(miVenta2);
            misVentas.altaVenta(miVenta3);
            misVentas.mostrarVentas();

            Ventas frescaVenta = new Ventas();
            frescaVenta.IDVENTA = "V-03";
            frescaVenta.FECHAVENTA = "25/07/2024";
            frescaVenta.ID_EMPLEADO = "E-01";

            misVentas.actualizarVenta(frescaVenta);
            Console.WriteLine("Actualizando la tabla ventas");
            misVentas.mostrarVentas();
            misVentas.borrarVenta(miVenta3);
            Console.WriteLine("Mostrando Ventas");
            misVentas.mostrarVentas();


            ordenVenta ordenVenta1 = new ordenVenta();
            ordenVenta1.IDVENTA = "V-01";
            ordenVenta1.IDRODUCTO = "P-02";
            ordenVenta1.CANTIDADPRODUCTO = 5;

            ordenVenta ordenVenta2 = new ordenVenta();
            ordenVenta2.IDVENTA = "V-02";
            ordenVenta2.IDRODUCTO = "P-05";
            ordenVenta2.CANTIDADPRODUCTO = 3;

            ordenVenta ordenVenta3 = new ordenVenta();
            ordenVenta3.IDVENTA = "V-03";
            ordenVenta3.IDRODUCTO = "P-01";
            ordenVenta3.CANTIDADPRODUCTO = 4;
            
            Console.WriteLine("Mostrando ordenes de venta");
            gestorOrdenVentas misOrdenes=new gestorOrdenVentas();
            misOrdenes.altaOrden(ordenVenta1);
            misOrdenes.altaOrden(ordenVenta2);
            misOrdenes.altaOrden(ordenVenta3);

            ordenVenta nuevaOrden=new ordenVenta();
            nuevaOrden.IDVENTA = "V-01";
            nuevaOrden.IDRODUCTO = "P-02";
            nuevaOrden.CANTIDADPRODUCTO= 10;

            misOrdenes.mostrarOrden();
            misOrdenes.actualizarOrden(nuevaOrden);
            Console.WriteLine("Actualizando ordenes");
            misOrdenes.mostrarOrden();
            Console.WriteLine("Borrando una orden");
            misOrdenes.borrarOrden(ordenVenta1);
            misOrdenes.mostrarOrden();
        }
        /*
        animalGestor.AltaAnimales("A-006","Caballo");
        animalGestor.AltaAnimales("A-007", "Castor");
        animalGestor.AltaAnimales("A-008", "Elefante");
        animalGestor.MostrarAnimales();
        */
    }
}

//Se realizaron las mejoras abajo mencionadas
/*      Apuntes para MEJORA. Se tiene que rehacer los constructores de las clases de Animales, Empleados, etc para que se pueda agregar directamente el objeto y las validaciones 
 *      también estén dentro de ellas, así las clases para la gestión se atomicen de mejor forma para escalabilidad 

public class gestorEmpleados
{
    List<Empleados> listaEmpleados = new List<Empleados>();
    //Se pasa el objeto de tipo Empleados para evitar su edición dentro del método altaEmpleados
    public void altaEmpleados(Empleados nuevoEmpleado)
    {
        if (listaEmpleados.Any(emplo => emplo.ID_EMPLEADO == nuevoEmpleado.ID_EMPLEADO))
        {
            Console.WriteLine("Ya existe un empleado con ese ID");
            return;
        }

        listaEmpleados.Add(nuevoEmpleado);
    }

    public void mostrarEmpleados()
    {
        foreach (Empleados em in listaEmpleados)
        {
            Console.WriteLine($"ID Empleado: {em.ID_EMPLEADO}, Nombre: {em.NOMBRE_EMPLEADO}");
        }
    }
}

Empleados miEmpleado = new Empleados(idEmplo);
miEmpleado.NOMBRE_EMPLEADO = nomEmplo;

gestor.altaEmpleados(miEmpleado);

*/

