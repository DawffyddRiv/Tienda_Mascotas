using System.Diagnostics.Metrics;

namespace Tienda_Mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gestorAnimales animalGestor = new gestorAnimales();

            animalGestor.AltaAnimales("A-006","Caballo");
            animalGestor.AltaAnimales("A-007", "Castor");
            animalGestor.AltaAnimales("A-008", "Elefante");
            animalGestor.MostrarAnimales();
            Console.WriteLine("");
            animalGestor.ActualizarAnimales("A-006", "Leon");
            animalGestor.MostrarAnimales();
            Console.WriteLine("");
            animalGestor.borrarAnimal("A-006");
            Console.WriteLine("Lista Actualizada de Animales");
            animalGestor.MostrarAnimales();
            Console.WriteLine("");
            Console.WriteLine("Sigue la lista de empleados");
            gestorEmpleados miStaff = new gestorEmpleados();
            miStaff.altaEmpleados("E-001", "Pandora");
            miStaff.mostrarEmpleados();
            

        }
       
    }


    public class Animales
    {
        private string id_Animal;
        private string nombre_animal;

        public Animales(string id_Animal)
        {
            this.id_Animal = id_Animal;
        }

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

        public void AltaAnimales(string idAnimal, string nombreAnim)
        {
            
            if (listaAnimales.Any(anim => anim.IDANIMAL == idAnimal))
            {
                Console.WriteLine("Ya existe un animal con ese ID.");
                return;
            }
            else
            {
                Animales miAnimal = new Animales(idAnimal);
                miAnimal.NOMBRE_ANIMAL = nombreAnim;
                listaAnimales.Add(miAnimal);
            }
        }
        public void ActualizarAnimales(string idAnimal, string nombreAnim) //Estamos intentando actualizar la instancia . Creo que tiene que ser un setter
        {   

            Animales animalExistente = listaAnimales.FirstOrDefault(a => a.IDANIMAL == idAnimal);//Buscamos y el primero que encontremos(o no) se guarda en una objeto Animales.Si hay duplicados se usa listaAnimales.Where

            if (animalExistente != null)
            {
                animalExistente.NOMBRE_ANIMAL = nombreAnim;
                Console.WriteLine("Animal actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un animal con ese ID.");
            }

        }

        public void borrarAnimal(string idAnimal) 
        { 
            Animales eraAnimal=listaAnimales.FirstOrDefault(a=>a.IDANIMAL==idAnimal);
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
        public Empleados(string idempleado)
        {
            this.idEmpleado = idempleado;
        }

        public string ID_EMPLEADO
        {
            get { return this.idEmpleado; }
            /*set { this.idEmpleado = value; }*/
        }
        public string NOMBRE_EMPLEADO
        {
            get { return this.nombreEmpleado; }
            set { this.nombreEmpleado = value; }
        }

    }

    public class gestorEmpleados //Se realiza el gestor. Metodos de gestión para la tabla Empleados
    {
        List<Empleados> listaEmpleados=new List<Empleados>();

        public void altaEmpleados(string idEmplo,string nomEmplo) 
        {
            if (listaEmpleados.Any(emplo => emplo.ID_EMPLEADO == idEmplo))
            {
                Console.WriteLine("Ya existe un empleado con ese ID");
                return;
            }
            else 
            {

                Empleados miEmpleado = new Empleados(idEmplo);
                miEmpleado.NOMBRE_EMPLEADO = nomEmplo;
                listaEmpleados.Add(miEmpleado);
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

    public class Productos
    {
        private string idProducto;
        private string nombreProducto;
        private double precio;
        private string id_Animal;

        public Productos(string idProducto)
        {
            this.idProducto = idProducto;
        }
        public string ID_PRODUCTO
        {
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

        public Ventas(string idVenta, string idVenddor)
        {
            this.idVentas = idVenta;
            //this.idProducto = idProduct;
            this.idVendedor = idVenddor;
        }
        public string FECHAVENTA
        {
            get { return this.fechaVenta; }
            set { this.fechaVenta = value; }
        }

    }
    public class ordenVenta
    {
        private string idVenta;
        private string idProducto;
        private int cantidadProducto;
        public ordenVenta(string idVenta, string idProducto)
        {
            this.idVenta = idVenta;
            this.idProducto = idProducto;           
        }

        public int CANTIDADPRODUCTO
        {
            get { return this.cantidadProducto; }
            set { this.cantidadProducto = value; }
        }
    }


}

