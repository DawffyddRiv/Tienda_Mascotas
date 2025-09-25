using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.MenusAcceso
{
    public class MenuPrincipal
    {
        public void Menu() 
        {
            int opcion;
            do {
                Console.WriteLine("=======================Tienda de Mascotas 'Los Michis lml===================='");
                Console.WriteLine("----------------------------Selecciona una opción----------------------------");
                Console.WriteLine("1 . Animales ");
                Console.WriteLine("2 . Empelados");
                Console.WriteLine("3 . Productos");
                Console.WriteLine("4 . Ventas");
                Console.WriteLine("5 . Ordenes de venta");
                Console.WriteLine("0 . ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))//Intentamos hacer el casteo de la variable opcion
                {
                    opcion = -1;
                }

            } while (opcion !=0);

        }
    }
}
