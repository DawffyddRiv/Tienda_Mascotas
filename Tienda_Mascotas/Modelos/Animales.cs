using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Mascotas.Modelos
{
    public class Animales
    {
        private string id_Animal;
        private string nombre_animal;

        public string IDANIMAL
        {
            get { return this.id_Animal; }
            set { this.id_Animal = value; }

        }
        public string NOMBRE_ANIMAL
        {
            get { return this.nombre_animal; }
            set { this.nombre_animal = value; }
        }
        public override string ToString() //Se puede sustituir pero no se comprende del todo su funcionamiento.Pendiente
        {
            return $"ID: {IDANIMAL}, Nombre: {NOMBRE_ANIMAL}";
        }
    }
      
   
   
}
