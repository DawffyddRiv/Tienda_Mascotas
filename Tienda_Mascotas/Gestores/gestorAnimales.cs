using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Mascotas.Modelos;

namespace Tienda_Mascotas.Gestores
{
    public class gestorAnimales
    {
        private List<Animales> listaAnimales = new List<Animales>();

        public void AltaAnimales(Animales animal)
        {

            if (listaAnimales.Any(anim => anim.IDANIMAL == animal.IDANIMAL))
            {
                Console.WriteLine("Ya existe un animal con ese ID.");
                return;
            }
            else
            {
                listaAnimales.Add(animal);
            }
        }
        public void ActualizarAnimales(Animales anim) //Se actualízó a crear el objeto fuera y pasarlo como parámetro
        {

            Animales animalExistente = listaAnimales.FirstOrDefault(a => a.IDANIMAL == anim.IDANIMAL);//Buscamos la primera referencia que encontremos, se guarda como animalExistente.Si hay duplicados se usa listaAnimales.Where

            if (animalExistente != null)
            {
                //anim.IDANIMAL =animalExistente.IDANIMAL ;
                animalExistente.NOMBRE_ANIMAL = anim.NOMBRE_ANIMAL;

                Console.WriteLine("Animal actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un animal con ese ID.");
            }

        }

        public void borrarAnimal(Animales animbo)
        {
            Animales eraAnimal = listaAnimales.FirstOrDefault(a => a.IDANIMAL == animbo.IDANIMAL);
            if (eraAnimal != null)
            {
                listaAnimales.Remove(eraAnimal);
                Console.WriteLine("Animal eliminado de la lista");
            }
            else
            {
                Console.WriteLine("No se encontró un animal con ese ID.");
            }

        }

        public void MostrarAnimales()
        {
            foreach (Animales a in listaAnimales)
            {
                Console.WriteLine($"ID: {a.IDANIMAL} Nombre del Animal {a.NOMBRE_ANIMAL} ");
                //Console.WriteLine(a);
            }
        }

    }
}
