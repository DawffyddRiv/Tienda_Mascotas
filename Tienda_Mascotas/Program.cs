namespace Tienda_Mascotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animales animal_1=new Animales("A-001");//{NOMBRE_ANIMAL="Gato"} ó
            animal_1.NOMBRE_ANIMAL = "Perro";
            
            Console.WriteLine($"Clave de animal {animal_1.IDANIMAL} y su tipo es {animal_1.NOMBRE_ANIMAL}");
            //Agrego tabla de animales
            List<Animales> listAnimales=new List<Animales>();
           //Agrego animal a la lista
            listAnimales.Add(animal_1);
            //Agrego tabla Empleados(Pendiente)
            //agrego tabla Productos
            List<Productos> listProductsos=new List<Productos>();
            Productos prod1 = new Productos("P-001") { NOMBRE_PRODUCTO = "Croquetas perro", PRECIO = 200, ID_ANIMAL = "A-001" };
            Console.WriteLine($"ID producto {prod1.ID_PRODUCTO} , Nombre: {prod1.NOMBRE_PRODUCTO} ,Precio: {prod1.PRECIO} ,ClaveAnimal: {prod1.ID_ANIMAL} ");
            
            
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
        private string idProducto;
        private string idVendedor;
        private string fechaVenta;

        public Ventas(string idVenta, string idProduct, string idVenddor)
        {
            this.idVentas = idVenta;
            this.idProducto = idProduct;
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
        public int CANTIDADPRODUCTO
        {
            get { return this.cantidadProducto; }
            set { this.cantidadProducto = value; }
        }
    }


}

