using System.Diagnostics.Metrics;

namespace Tienda_Mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animales> listaAnimales = new List<Animales>();
            AltaAnimales(listaAnimales,"A-003","Caballo");
            foreach (Animales An in listaAnimales) { Console.WriteLine(An); }

        }
        public static void AltaAnimales(List<Animales> milista, string idAnimal, string nombreAnim)
        {            
            Animales miAnimal = new Animales(idAnimal);
            miAnimal.NOMBRE_ANIMAL = nombreAnim;
            milista.Add(miAnimal);
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
            /* set { this.id_Animal = value; }*/

        }
        public string NOMBRE_ANIMAL
        {
            get { return this.nombre_animal; }
            set { this.nombre_animal = value; }
        }
        public override string ToString()
        {
            return $"ID: {IDANIMAL}, Nombre: {NOMBRE_ANIMAL}";
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

