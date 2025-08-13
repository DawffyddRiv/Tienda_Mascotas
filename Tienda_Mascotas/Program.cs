namespace Tienda_Mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animales miAnimal=new Animales();

            miAnimal.setNombreAnimal("Gato");
            Console.WriteLine(miAnimal.getNombreAnimal());
        }

    }

    public class Animales

    {
        private string id_Animal;
        private string nombre_animal;

        public void setIDAnimal(string identificador) {
            id_Animal = identificador;
        }
        public string getIdAnimal() { 
            return id_Animal;
        }  
        public void setNombreAnimal(string nombre)
        { 
            nombre_animal = nombre;

        }           
       
        public string getNombreAnimal()
        {
            return nombre_animal;
        }

    }
   

}

