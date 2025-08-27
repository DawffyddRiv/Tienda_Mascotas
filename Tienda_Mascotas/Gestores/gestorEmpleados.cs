using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascotas.Modelos;

namespace Tienda_Mascotas.Gestores
{
    public class gestorEmpleados
    {
        List<Empleados> listaEmpleados = new List<Empleados>();

        public void altaEmpleados(Empleados nuevoEmpleado)
        {

            if (listaEmpleados.Any(emplo => emplo.ID_EMPLEADO == nuevoEmpleado.ID_EMPLEADO))
            {
                Console.WriteLine("Ya existe un empleado con ese ID");
                return;
            }
            else
            {

                listaEmpleados.Add(nuevoEmpleado);
            }
        }
        public void mostrarEmpleados()
        {
            foreach (Empleados em in listaEmpleados)
            {
                Console.WriteLine($"ID Empleado: {em.ID_EMPLEADO}, Nombre: {em.NOMBRE_EMPLEADO}");
            }
        }
        public void actualizaEmpleado(Empleados empleadoCambia)
        {
            Empleados empleadoExistente = listaEmpleados.FirstOrDefault(emp => emp.ID_EMPLEADO == empleadoCambia.ID_EMPLEADO);
            if (empleadoCambia != null)
            {
                empleadoExistente.NOMBRE_EMPLEADO = empleadoCambia.NOMBRE_EMPLEADO;
            }
            else
            {
                Console.WriteLine("No se encontró un empleado con ese ID.");
            }
        }
        public void borraEmpleado(Empleados emple)
        {
            if (listaEmpleados.Any(emp => emp.ID_EMPLEADO == emple.ID_EMPLEADO))
            {
                listaEmpleados.Remove(emple);
            }
            else
            {
                Console.WriteLine("No se encontró algún empleado con ese ID.");
            }
        }
    }
}
