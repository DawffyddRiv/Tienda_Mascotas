using System.Diagnostics.Metrics;
using System.Numerics;
using Tienda_Mascotas;

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
            Animales animal3=new Animales();
            animal3.IDANIMAL = "A-02";
            animal3.NOMBRE_ANIMAL = "Fido";
            animalGestor.AltaAnimales(animal3);
            Console.WriteLine("");
            animalGestor.MostrarAnimales();
            animalGestor.borrarAnimal(animal3);
            Console.WriteLine("");
            animalGestor.MostrarAnimales();

            Empleados miEmpleado = new Empleados();
        }
            
            /*
                
            animalGestor.AltaAnimales("A-006","Caballo");
            animalGestor.AltaAnimales("A-007", "Castor");
            animalGestor.AltaAnimales("A-008", "Elefante");
            animalGestor.MostrarAnimales();
            */       
    }


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
        public override string ToString() //Se puede sustituir pero no se comprende del todo su funcionamiento
        {
            return $"ID: {IDANIMAL}, Nombre: {NOMBRE_ANIMAL}";
        }

    }
    //Se plantea separar las entidades de los gestores.Primer gestor-> Animales
    public class gestorAnimales 
    {        
        private List<Animales> listaAnimales=new List<Animales>();

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
        public void ActualizarAnimales(Animales anim) //Estamos intentando actualizar la instancia . Creo que tiene que ser un setter
        {   

            Animales animalExistente = listaAnimales.FirstOrDefault(a => a.IDANIMAL == anim.IDANIMAL);//Buscamos y el primero que encontremos(o no) se guarda en una objeto Animales.Si hay duplicados se usa listaAnimales.Where

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
            Animales eraAnimal=listaAnimales.FirstOrDefault(a=>a.IDANIMAL==animbo.IDANIMAL);
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

    
    public class Empleados
    {
        private string idEmpleado;
        private string nombreEmpleado;
        //public Empleados(string idempleado)
        
        public string ID_EMPLEADO
        {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value;}
        }
        public string NOMBRE_EMPLEADO
        {
            get { return this.nombreEmpleado; }
            set { this.nombreEmpleado = value; }
        }

    }
    //Vamos aqui. Siguen los empleados.
    public class gestorEmpleados //Se realiza el gestor. Metodos de gestión para la tabla Empleados
    {
        List<Empleados> listaEmpleados=new List<Empleados>();

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
    }
    /*
    public class Productos
    {
        private string idProducto;
        private string nombreProducto;
        private double precio;
        private string id_Animal;
                
        public string ID_PRODUCTO
        {
            set { this.idProducto = value; }
            get { return this.idProducto; }
        }
        public string NOMBRE_PRODUCTO
        {
            get { return this.nombreProducto; }
            set { this.nombreProducto = value; }
        }
        public double PRECIO
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
        public string ID_ANIMAL
        {
            get { return this.id_Animal; }
            set { this.id_Animal = value; }
        }
    }
    public class Ventas
    {
        private string idVentas;
        //private string idProducto;
        private string idVendedor;
        private string fechaVenta;

        public string IDVENTA
        {
            get { return this.idVentas; }
            set {this .idVentas = value; }           
        }
        public string FECHAVENTA
        {
            get { return this.fechaVenta; }
            set { this.fechaVenta = value; }
        }
        public string ID_EMPLEADO 
        {
            get{ return this.idVendedor; }
            set{ this.idVendedor = value;
        }
    }
    public class ordenVenta
    {
        private string idVenta;
        private string idProducto;
        private int cantidadProducto;

        public string IDVENTA 
        {
            get { return this.idVenta; }
            set { this.idVenta = value; }
        }
        public string IDRODUCTO
            {
                get { return this.idProducto; }
                set { this.idProducto = value; }
        }

        public int CANTIDADPRODUCTO
        {
            get { return this.cantidadProducto; }
            set { this.cantidadProducto = value; }
        }
    }
    */

}


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

